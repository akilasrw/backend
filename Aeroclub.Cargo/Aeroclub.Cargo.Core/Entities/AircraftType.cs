
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class AircraftType : AuditableEntity
    {
        public string Name { get; set; }
        public AircraftTypes Type { get; set; }

        public virtual ICollection<AircraftSubType> AircraftSubTypes { get; set; }
    }
}
