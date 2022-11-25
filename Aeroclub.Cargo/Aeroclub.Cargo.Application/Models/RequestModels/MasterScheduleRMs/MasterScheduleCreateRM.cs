using Aeroclub.Cargo.Common.Enums;
using System.ComponentModel.DataAnnotations;


namespace Aeroclub.Cargo.Application.Models.RequestModels.MasterScheduleRMs
{
    public class MasterScheduleCreateRM
    {
        [Required(ErrorMessage = "Aircraft ID required.")]
        public Guid AircraftId { get; set; }

        [Required(ErrorMessage = "Schedule start date required.")]
        public DateTime ScheduleStartDate { get; set; }
        public DateTime ScheduleEndDate { get; set; }

        [Required(ErrorMessage = "Schedule start time required.")]
        public string ScheduleStartTime { get; set; } = null!;

        [Required(ErrorMessage = "Number of hours required.")]
        public double NumberOfHours { get; set; }
        public string DaysOfWeek { get; set; } = null!;

        [Required(ErrorMessage = "Schedule status required.")]
        public ScheduleStatus ScheduleStatus { get; set; }

        [Required(ErrorMessage = "Schedule calendar type required.")]
        public CalendarType CalendarType { get; set; }
    }
}
