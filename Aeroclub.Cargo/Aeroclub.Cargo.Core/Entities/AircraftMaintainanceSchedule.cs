using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class AircraftMaintainanceSchedule : AuditableEntity
    {
        public Guid AircraftScheduleId { get; set; }

        public virtual AircraftSchedule AircraftSchedule { get; set; } = null!;
    }
}
