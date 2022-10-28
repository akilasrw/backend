using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using Aeroclub.Cargo.Data;
using Aeroclub.Cargo.Infrastructure.Authorization.Interfaces;
using Aeroclub.Cargo.Infrastructure.Authorization.Models;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using BCryptNet = BCrypt.Net.BCrypt;

namespace Aeroclub.Cargo.Application.Services
{
    public class UserService : BaseService,IUserService
    {
        private readonly CargoContext _context;
        private readonly UserManager<AppUser> _userManager;
        private IJwtUtils _jwtUtils;
        private readonly IConfiguration _configuration;

        public UserService(CargoContext context,
            IUnitOfWork unitOfWork,
            IMapper mapper,
            UserManager<AppUser> userManager,
            IJwtUtils jwtUtils,
            IConfiguration configuration) : base(unitOfWork, mapper)
        {
            _context = context;
            _userManager = userManager;
            _jwtUtils = jwtUtils;
            _configuration = configuration;
        }

        public ServiceResponse<AuthenticateResponse> Authenticate(AuthenticateRequest model, string ipAddress)
        {
            var user = _context.AppUsers.SingleOrDefault(x=>x.UserName == model.Username);           

            // validate
            if (user == null || !BCryptNet.Verify(model.Password, user.PasswordHash))
                return  new ServiceResponse<AuthenticateResponse>(null, "Username or Password is incorrect.", ServiceResponseStatus.ValidationError);

            // authentication successful so generate jwt and refresh tokens
            var jwtToken = _jwtUtils.GenerateJwtToken(user);
            var refreshToken = _jwtUtils.GenerateRefreshToken(ipAddress);
            user.RefreshTokens.Add(refreshToken);

            // remove old refresh tokens from user
            removeOldRefreshTokens((AppUser)user);

            // save changes to db
            _context.Update(user);
            _context.SaveChanges();

            var result = new AuthenticateResponse(user, jwtToken, refreshToken.Token);
            return new ServiceResponse<AuthenticateResponse>(result);
        }

        public ServiceResponse<AuthenticateResponse> CargoAgentAuthenticate(AuthenticateRequest model, string ipAddress)
        {
            var user = _context.AppUsers.SingleOrDefault(x => x.UserName == model.Username);

            // validate
            if (user == null || !BCryptNet.Verify(model.Password, user.PasswordHash))
                return new ServiceResponse<AuthenticateResponse>(null, "Username or Password is incorrect.", ServiceResponseStatus.ValidationError);

            var cargoAgent = _context.CargoAgents.SingleOrDefault(x => x.AppUserId == user.Id);
            if (cargoAgent == null)
                return new ServiceResponse<AuthenticateResponse>(null, "User not found.", ServiceResponseStatus.ValidationError);

            if(cargoAgent.Status == CargoAgentStatus.Suspended)
                return new ServiceResponse<AuthenticateResponse>(null, "Access denied.", ServiceResponseStatus.ValidationError);

            if (cargoAgent.Status == CargoAgentStatus.Pending || cargoAgent.Status == CargoAgentStatus.None)
                return new ServiceResponse<AuthenticateResponse>(null, "Pending approval.", ServiceResponseStatus.ValidationError);

            // authentication successful so generate jwt and refresh tokens
            var jwtToken = _jwtUtils.GenerateJwtToken(user);
            var refreshToken = _jwtUtils.GenerateRefreshToken(ipAddress);
            user.RefreshTokens.Add(refreshToken);

            // remove old refresh tokens from user
            removeOldRefreshTokens((AppUser)user);

            // save changes to db
            _context.Update(user);
            _context.SaveChanges();

            var result = new AuthenticateResponse(user, jwtToken, refreshToken.Token);
            return new ServiceResponse<AuthenticateResponse>(result);
        }

        public ServiceResponse<AuthenticateResponse> RefreshToken(string token, string ipAddress)
        {
            var user = getUserByRefreshToken(token);
            if (user == null)
                return new ServiceResponse<AuthenticateResponse>(null, "Invalid token", ServiceResponseStatus.ValidationError);

            var refreshToken = user.RefreshTokens.Single(x => x.Token == token);

            if (refreshToken.IsRevoked)
            {
                // revoke all descendant tokens in case this token has been compromised
                revokeDescendantRefreshTokens(refreshToken, user, ipAddress, $"Attempted reuse of revoked ancestor token: {token}");
                _userManager.UpdateAsync(user);
                _context.Update(user);
                _context.SaveChanges();
            }

            if (!refreshToken.IsActive)
                return new ServiceResponse<AuthenticateResponse>(null, "Invalid token", ServiceResponseStatus.ValidationError);

            // replace old refresh token with a new one (rotate token)
            var newRefreshToken = rotateRefreshToken(refreshToken, ipAddress);
            user.RefreshTokens.Add(newRefreshToken);

            // remove old refresh tokens from user
            removeOldRefreshTokens(user);

            // save changes to db
            //_userManager.UpdateAsync(user);
            _context.Update(user);
            _context.SaveChanges();

            // generate new jwt
            var jwtToken = _jwtUtils.GenerateJwtToken(user);

            var result = new AuthenticateResponse(user, jwtToken, newRefreshToken.Token);
            return new ServiceResponse<AuthenticateResponse>(result);
        }

        public void RevokeToken(string token, string ipAddress)
        {
            var user = getUserByRefreshToken(token);
            var refreshToken = user.RefreshTokens.Single(x => x.Token == token);

            if (!refreshToken.IsActive)
                new ServiceResponse<AuthenticateResponse>(null, "Invalid token", ServiceResponseStatus.ValidationError);

            // revoke token and save
            revokeRefreshToken(refreshToken, ipAddress, "Revoked without replacement");
            _userManager.UpdateAsync(user);
            _context.Update(user);
            _context.SaveChanges();
        }

        public IEnumerable<AppUser> GetAll()
        {
            return _context.AppUsers.ToList(); ;
        }

        public AppUser GetById(Guid id)
        {
            var user = _context.AppUsers.Find(id);
            if (user == null) new ServiceResponse<AuthenticateResponse>(null, "User not found", ServiceResponseStatus.ValidationError);
            return user;
        }

        // helper methods

        private AppUser getUserByRefreshToken(string token)
        {
            var user = _context.AppUsers.SingleOrDefault(u => u.RefreshTokens.Any(t => t.Token == token));

            if (user == null)
                new ServiceResponse<AuthenticateResponse>(null, "Invalid token", ServiceResponseStatus.ValidationError);

            return user;
        }

        private RefreshToken rotateRefreshToken(RefreshToken refreshToken, string ipAddress)
        {
            var newRefreshToken = _jwtUtils.GenerateRefreshToken(ipAddress);
            revokeRefreshToken(refreshToken, ipAddress, "Replaced by new token", newRefreshToken.Token);
            return newRefreshToken;
        }

        private void removeOldRefreshTokens(AppUser user)
        {
            // remove old inactive refresh tokens from user based on TTL in app settings
            user.RefreshTokens.RemoveAll(x =>
                !x.IsActive &&
                x.Created.AddDays(double.Parse(_configuration["Token:RefreshTokenTTL"])) <= DateTime.UtcNow);
        }

        private void revokeDescendantRefreshTokens(RefreshToken refreshToken, AppUser user, string ipAddress, string reason)
        {
            // recursively traverse the refresh token chain and ensure all descendants are revoked
            if (!string.IsNullOrEmpty(refreshToken.ReplacedByToken))
            {
                var childToken = user.RefreshTokens.SingleOrDefault(x => x.Token == refreshToken.ReplacedByToken);
                if (childToken.IsActive)
                    revokeRefreshToken(childToken, ipAddress, reason);
                else
                    revokeDescendantRefreshTokens(childToken, user, ipAddress, reason);
            }
        }

        private void revokeRefreshToken(RefreshToken token, string ipAddress, string reason = null, string replacedByToken = null)
        {
            token.Revoked = DateTime.UtcNow;
            token.RevokedByIp = ipAddress;
            token.ReasonRevoked = reason;
            token.ReplacedByToken = replacedByToken;
        }
    }
}
