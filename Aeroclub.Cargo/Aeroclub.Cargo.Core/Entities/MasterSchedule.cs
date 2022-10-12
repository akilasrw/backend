using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class MasterSchedule : AuditableEntity
    {
        public DateTime ScheduleStartDateTime { get; set; }
        public DateTime ScheduleEndDateTime { get; set; }
        public string DaysOfWeek { get; set; } = null!;
        public ScheduleStatus ScheduleStatus { get; set; }
        public CalendarType CalendarType { get; set; }

        public virtual ICollection<AircraftSchedule>? AircraftSchedules { get; set; }
    }
}
