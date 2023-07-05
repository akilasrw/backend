using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Infrastructure.Authorization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IUserService
    {
        ServiceResponse<AuthenticateResponse> Authenticate(AuthenticateRequest model, string ipAddress);
        ServiceResponse<AuthenticateResponse> CargoAgentAuthenticate(AuthenticateRequest model, string ipAddress);
        ServiceResponse<AuthenticateResponse> RefreshToken(string token, string ipAddress);
        void RevokeToken(string token, string ipAddress);
        IEnumerable<AppUser> GetAll();
        AppUser GetById(Guid id);
        Task<AppUser> ExistsAppUserEmailAsync(string email);
    }
}
