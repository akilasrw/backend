using System.ComponentModel.DataAnnotations;

namespace Aeroclub.Cargo.Application.Models.RequestModels.AircraftScheduleRMs
{
    public class AircraftScheduleRM
    {
        [Required(ErrorMessage = "Schedule start date time required.")]
        public DateTime ScheduleStartDateTime { get; set; }

        [Required(ErrorMessage = "Schedule end date time required.")]
        public DateTime ScheduleEndDateTime { get; set; }
        public bool IsCompleted { get; set; }

        [Required(ErrorMessage = "Master schedule required.")]
        public Guid MasterScheduleId { get; set; }
        public Guid? AircraftId { get; set; }
    }
}
