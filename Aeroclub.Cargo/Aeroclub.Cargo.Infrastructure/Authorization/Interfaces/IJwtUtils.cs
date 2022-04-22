using Aeroclub.Cargo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Infrastructure.Authorization.Interfaces
{
    public interface IJwtUtils
    {
        public string GenerateJwtToken(AppUser user);
        public Guid? ValidateJwtToken(string token);
        public RefreshToken GenerateRefreshToken(string ipAddress);
        string RandomTokenString();
    }
}
