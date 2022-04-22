using System.Linq;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.RequestModels;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Data;
using Aeroclub.Cargo.Infrastructure.Authorization.Interfaces;
using AutoMapper;
using BC = BCrypt.Net.BCrypt;

namespace Aeroclub.Cargo.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly CargoContext _context;
        private readonly IJwtUtils _jwtUtils;
        private readonly IMapper _mapper;

        public AccountService(CargoContext context,
            IJwtUtils jwtUtils,
            IMapper mapper)
        {
            _context = context;
            _jwtUtils = jwtUtils;
            _mapper = mapper;
        }

        public void Register(RegisterRequestRM model, string origin)
        {
            // validate
            if (_context.AppUsers.Any(x => x.UserName == model.UserName))
            {
                return;
            }

            // map model to new account object
            var user = _mapper.Map<AppUser>(model);

            //user.Created = DateTime.UtcNow;
            user.VerificationToken = randomTokenString();

            // hash password
            user.PasswordHash = BC.HashPassword(model.Password);

            // save account
            _context.AppUsers.Add(user);
            _context.SaveChanges();
        }

        private string randomTokenString()
        {
            return _jwtUtils.RandomTokenString();
        }
    }
}
