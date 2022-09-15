using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleVMs
{
    public class FlightScheduleVM
    {
        public string? FlightNumber { get; set; } = null;
        public DateTime ScheduledDepartureDateTime { get; set; }
        public DateTime ActualDepartureDateTime { get; set; }
        public FlightScheduleStatus FlightScheduleStatus { get; set; }
        public string OriginAirportCode { get; set; } = null!;
        public string DestinationAirportCode { get; set; } = null!;
        public string OriginAirportName { get; set; } = null!;
        public string DestinationAirportName { get; set; } = null!;
        public string? AircraftRegNo { get; set; } = null;
        public Guid? AircraftId { get; set; }

    }
}
