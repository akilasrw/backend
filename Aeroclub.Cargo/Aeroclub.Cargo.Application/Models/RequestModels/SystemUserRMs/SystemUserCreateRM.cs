using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.RequestModels.SystemUserRMs
{
    public class SystemUserCreateRM: BaseRM
    {
        [Required(ErrorMessage = "First name required")]
        public string FirstName { get; set; } = null!;

        public string? LastName { get; set; }

        [Required(ErrorMessage = "Username required")]
        public string UserName { get; set; } = null!;

        [Required(ErrorMessage = "Phone number required")]
        public string PhoneNumber { get; set; } = null!;

        [Required(ErrorMessage = "Email required")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Country required")]
        public Guid CountryId { get; set; }

        [Required(ErrorMessage = "Base airport required")]
        public Guid BaseAirportId { get; set; }

        [Required(ErrorMessage = "City required")]
        public string City { get; set; } = null!;

        [Required(ErrorMessage = "Access Portal required")]
        public AccessPortalLevel AccessPortalLevel { get; set; }

        [Required(ErrorMessage = "User Role required")]
        public UserRole UserRole { get; set; }

        [Required(ErrorMessage = "User Status required")]
        public UserStatus UserStatus { get; set; }
    }
}
