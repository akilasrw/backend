using Aeroclub.Cargo.Common.Enums;
using System.ComponentModel.DataAnnotations;


namespace Aeroclub.Cargo.Application.Models.RequestModels.MasterScheduleRMs
{
    public class MasterScheduleRM
    {
        [Required(ErrorMessage = "Schedule start date time required")]
        public DateTime ScheduleStartDateTime { get; set; }

        [Required(ErrorMessage = "Schedule end date time required")]
        public DateTime ScheduleEndDateTime { get; set; }

        [Required(ErrorMessage = "Days of week required")]
        public string DaysOfWeek { get; set; } = null!;

        [Required(ErrorMessage = "Schedule status required")]
        public ScheduleStatus ScheduleStatus { get; set; }

        [Required(ErrorMessage = "Schedule calendar type required")]
        public CalendarType CalendarType { get; set; }
    }
}
