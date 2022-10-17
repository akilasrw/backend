using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.ViewModels.MasterScheduleVMs
{
    public class MasterScheduleVM : BaseVM
    {
        public DateTime ScheduleStartDateTime { get; set; }
        public DateTime ScheduleEndDateTime { get; set; }
        public string DaysOfWeek { get; set; } = null!;
        public ScheduleStatus ScheduleStatus { get; set; }
        public CalendarType CalendarType { get; set; }
    }
}
