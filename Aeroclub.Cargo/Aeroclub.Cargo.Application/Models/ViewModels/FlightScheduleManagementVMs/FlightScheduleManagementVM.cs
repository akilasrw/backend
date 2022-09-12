
namespace Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleManagementVMs
{
    public class FlightScheduleManagementVM
    {
        public string? FlightNumber { get; set; } = null;
        public DateTime ScheduleStartDate { get; set; }
        public DateTime ScheduleEndDate { get; set; }
        public TimeSpan ScheduledTime { get; set; }
        public string DaysOfWeek { get; set; } = null!;
        public string OriginAirportCode { get; set; } = null!;
        public string DestinationAirportCode { get; set; } = null!;
        public string OriginAirportName { get; set; } = null!;
        public string DestinationAirportName { get; set; } = null!;
        public string? AircraftRegNo { get; set; } = null;
    }
}
