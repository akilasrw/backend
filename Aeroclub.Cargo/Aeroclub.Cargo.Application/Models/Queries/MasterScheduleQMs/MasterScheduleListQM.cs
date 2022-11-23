using System.ComponentModel.DataAnnotations;

namespace Aeroclub.Cargo.Application.Models.Queries.MasterScheduleQMs
{
    public class MasterScheduleListQM
    {
        [Required(ErrorMessage = "Schedule date required.")]
        public DateTime ScheduleStartDate { get; set; }
        public DateTime ScheduleEndDate { get; set; }
        public bool IsIncludeAircraft { get; set; }
        public bool IsIncludeFlightSchedules { get; set; }

    }
}
