using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class AircraftCharteredSchedule : AuditableEntity
    {
        public Guid AircraftSchduleId { get; set; }

        public virtual AircraftSchedule AircraftSchdule { get; set; } = null!;
    }
}
