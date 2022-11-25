using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class MasterSchedule : AuditableEntity
    {
        public DateTime ScheduleStartDate { get; set; }
        public DateTime ScheduleEndDate { get; set; }
        public TimeSpan ScheduleStartTime { get; set; }
        public double NumberOfHours { get; set; }
        public string DaysOfWeek { get; set; } = null!;
        public CalendarType CalendarType { get; set; }

        public virtual ICollection<AircraftSchedule>? AircraftSchedules { get; set; }
    }
}
