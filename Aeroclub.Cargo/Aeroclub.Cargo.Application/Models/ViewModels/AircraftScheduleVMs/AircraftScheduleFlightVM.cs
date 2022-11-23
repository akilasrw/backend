using Aeroclub.Cargo.Application.Models.Core;

namespace Aeroclub.Cargo.Application.Models.ViewModels.AircraftScheduleVMs
{
    public class AircraftScheduleFlightVM : BaseVM
    {
        public Guid OriginAirportId { get; set; }
        public Guid DestinationAirportId { get; set; }
        public string OriginAirportCode { get; set; } = null!;
        public string DestinationAirportCode { get; set; } = null!;
        public string OriginAirportName { get; set; } = null!;
        public string DestinationAirportName { get; set; } = null!;
        public DateTime FlightScheduleStartDateTime { get; set; }
        public DateTime FlightScheduleEndDateTime { get; set; }
    }

}
