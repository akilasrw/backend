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
        public DateTime ScheduleStartDateTime { get; set; }

        [Required(ErrorMessage = "Schedule end date time required.")]
        public DateTime ScheduleEndDateTime { get; set; }

        [Required(ErrorMessage = "Schedule status required.")]
        public ScheduleStatus ScheduleStatus { get; set; }
        public bool IsCompleted { get; set; }

    }
}
