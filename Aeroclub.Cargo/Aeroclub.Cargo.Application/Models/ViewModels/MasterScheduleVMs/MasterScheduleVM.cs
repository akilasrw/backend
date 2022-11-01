using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.ViewModels.MasterScheduleVMs
{
    public class MasterScheduleVM : BaseVM
    {
        public DateTime ScheduleStartDate { get; set; }
        public DateTime ScheduleEndDate { get; set; }
        public TimeSpan ScheduleStartTime { get; set; }
        public double NumberOfHours { get; set; }
        public string DaysOfWeek { get; set; } = null!;
        public ScheduleStatus ScheduleStatus { get; set; }
        public CalendarType CalendarType { get; set; }
    }
}
