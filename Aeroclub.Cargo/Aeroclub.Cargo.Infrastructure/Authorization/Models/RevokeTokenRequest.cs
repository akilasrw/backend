using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Infrastructure.Authorization.Models
{
    public class RevokeTokenRequest
    {
        public string? Token { get; set; }
    }
}
