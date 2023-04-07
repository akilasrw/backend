using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class ULDTracking : AuditableEntity
    {
        public DateTime LastUsedDate { get; set; }
        public string LastUsedFlightNumber { get; set; } = null!;
        public string LastLocatedAirportCode { get; set; } = null!;
        public Guid ULDId { get; set; }

        public virtual ULD uld { get; set; } 

    }
}
