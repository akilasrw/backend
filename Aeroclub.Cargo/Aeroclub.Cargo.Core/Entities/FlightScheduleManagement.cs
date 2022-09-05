using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class FlightScheduleManagement : AuditableEntity
    {
        public Guid? FlightId { get; set; }
        public Guid? AircraftId { get; set; }
        public DateTime ScheduleStartDate { get; set; }
        public DateTime ScheduleEndDate { get; set; }
        public string DaysOfWeek { get; set; } = null!;
        public bool IsFlightScheduleGenerated { get; set; }
    }
}
