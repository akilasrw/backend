using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class AircraftSchedule : AuditableEntity
    {
        public DateTime ScheduleStartDateTime { get; set; }
        public DateTime ScheduleEndDateTime { get; set; }
        public bool IsCompleted { get; set; }
        public Guid MasterScheduleId { get; set; }
        public Guid? AircraftId { get; set; }
        public ScheduleStatus ScheduleStatus { get; set; }

        public virtual MasterSchedule MasterSchedule { get; set; } = null!;  
        public virtual Aircraft? Aircraft { get; set; }
        public virtual ICollection<FlightSchedule>? FlightSchedules { get; set; }

        //public virtual AircraftCharteredSchedule? AircraftCharteredSchedule { get; set; }
        //public virtual AircraftMaintainanceSchedule? AircraftMaintainanceSchedule { get; set; }
    }
}
