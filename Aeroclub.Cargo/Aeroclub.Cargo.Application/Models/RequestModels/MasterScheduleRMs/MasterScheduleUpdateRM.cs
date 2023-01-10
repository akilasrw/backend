using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace Aeroclub.Cargo.Application.Models.RequestModels.MasterScheduleRMs
{
    public class MasterScheduleUpdateRM : BaseRM
    {
        [Required(ErrorMessage = "Aircraft ID required.")]
        public Guid AircraftId { get; set; }

        [Required(ErrorMessage = "Schedule start date time required.")]
        public DateTime ScheduleStartDate { get; set; }

        [Required(ErrorMessage = "Schedule end date time required.")]
        public DateTime ScheduleEndDate { get; set; }

        [Required(ErrorMessage = "Schedule status required.")]
        public ScheduleStatus ScheduleStatus { get; set; }
        public bool IsCompleted { get; set; }

        public string ScheduleStartTime { get; set; } = null!;
        public string ScheduleEndTime { get; set; } = null!;

    }
}
