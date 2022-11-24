using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace Aeroclub.Cargo.Application.Models.RequestModels.MasterScheduleRMs
{
    public class MasterScheduleUpdateRM : BaseRM
    {
        [Required(ErrorMessage = "Aircraft ID required.")]
        public Guid AircraftId { get; set; }

        [Required(ErrorMessage = "Schedule start date required.")]
        public DateTime ScheduleStartDate { get; set; }

        [Required(ErrorMessage = "Schedule start time required.")]
        public string ScheduleStartTime { get; set; } = null!;

        [Required(ErrorMessage = "Number of hours required.")]
        public double NumberOfHours { get; set; }

        [Required(ErrorMessage = "Schedule status required.")]
        public ScheduleStatus ScheduleStatus { get; set; }

        [Required(ErrorMessage = "Schedule calendar type required.")]
        public CalendarType CalendarType { get; set; }
    }
}
