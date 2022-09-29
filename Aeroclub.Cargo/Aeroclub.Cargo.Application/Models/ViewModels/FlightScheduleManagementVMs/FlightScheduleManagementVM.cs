
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleManagementVMs
{
    public class FlightScheduleManagementVM
    {
        public string? FlightNumber { get; set; } = null;
        public Guid FlightId { get; set; }
        public DateTime ScheduleStartDate { get; set; }
        public DateTime ScheduleEndDate { get; set; }
        public DateTime? ScheduledTime { get; set; }
        public string DaysOfWeek { get; set; } = null!;
        public string OriginAirportCode { get; set; } = null!;
        public string DestinationAirportCode { get; set; } = null!;
        public string OriginAirportName { get; set; } = null!;
        public string DestinationAirportName { get; set; } = null!;
        public AircraftSubTypes AircraftSubType { get; set; }

    }
}
