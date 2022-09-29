using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class AircraftSubType : AuditableEntity
    {
        public Guid AircraftTypeId { get; set; }
        public string Name { get; set; }
        public AircraftSubTypes Type { get; set; }
        public AircraftConfigType ConfigType { get; set; }

        public virtual AircraftType AircraftType { get; set; }
        public virtual ICollection<FlightScheduleSector> FlightScheduleSectors { get; set; }
        public virtual ICollection<FlightSchedule> FlightSchedules { get; set; }


    }
}
