using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Aeroclub.Cargo.Core.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        [JsonIgnore]
        public override string? PasswordHash { get; set; }
        public string? VerificationToken { get; set; }


        [JsonIgnore]
        public List<RefreshToken>? RefreshTokens { get; set; }
        public virtual ICollection<AppUserRole> UserRoles { get; set; }
    }
}
