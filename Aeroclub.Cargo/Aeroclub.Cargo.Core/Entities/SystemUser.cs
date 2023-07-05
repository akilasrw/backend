using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Core.Entities
{
    public class SystemUser : AuditableEntity
    {
        public string City { get; set; } = null!;
        public Guid AppUserId { get; set; }
        public Guid CountryId { get; set; }
        public Guid BaseAirportId { get; set; }
        public AccessPortalLevel AccessPortalLevel { get; set; }
        public UserRole UserRole { get; set; }
        public UserStatus UserStatus { get; set; }

        public virtual Country Country { get; set; } = null!;
        public virtual AppUser AppUser { get; set; } = null!;
        public virtual Airport BaseAirport { get; set; } = null!;
    }
}
