using Aeroclub.Cargo.Application.Models.Core;
using System.ComponentModel.DataAnnotations;

namespace Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleManagementRMs
{
    public class FlightScheduleManagementUpdateRM : BaseRM
    {
        [Required(ErrorMessage = "Flight Id required")]
        public Guid FlightId { get; set; }

        [Required(ErrorMessage = "Aircraft type required")]
        public Guid AircraftSubTypeId { get; set; }

        [Required(ErrorMessage = "Schedule start date required")]
        public DateTime ScheduleStartDate { get; set; }

        [Required(ErrorMessage = "Schedule end date required")]
        public DateTime ScheduleEndDate { get; set; }

        [Required(ErrorMessage = "Days of week required")]
        public string DaysOfWeek { get; set; } = null!;
        public bool IsFlightScheduleGenerated { get; set; }

    }
}
