using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Infrastructure.Authorization.Models
{
    public class AuthenticateRequest
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }

    public class TokenData
    {
        public string RefreshToken { get; set; }
    }

    public class UserPasswordRequest
    {
        [Required]
        public string Password { get; set; }
        public Guid AppUserId { get; set; }
    }
}
