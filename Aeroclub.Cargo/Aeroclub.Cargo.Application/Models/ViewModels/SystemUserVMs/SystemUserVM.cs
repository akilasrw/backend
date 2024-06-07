using Aeroclub.Cargo.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.ViewModels.SystemUserVMs
{
    public class SystemUserVM
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string City { get; set; } = null!;
        public string CountryName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string BaseAirportName { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public Guid AppUserId { get; set; }
        public Guid CountryId { get; set; }
        public Guid BaseAirportId { get; set; }
        public AccessPortalLevel AccessPortalLevel { get; set; }
        public UserRole UserRole { get; set; }
        public UserStatus UserStatus { get; set; }
    }
}
