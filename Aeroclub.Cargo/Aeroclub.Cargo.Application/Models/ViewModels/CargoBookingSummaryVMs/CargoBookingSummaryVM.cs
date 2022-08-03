using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingSummaryVMs
{
    public class CargoBookingSummaryVM : BaseVM
    {
        public string FlightNumber { get; set; } = null!;
        public DateTime ScheduledDepartureDateTime { get; set; }
        public string OriginAirportCode { get; set; } = null!;
        public string DestinationAirportCode { get; set; } = null!;
        public string OriginAirportName { get; set; } = null!;
        public string DestinationAirportName { get; set; } = null!;
        public string AircraftRegNo { get; set; } = null!;
        public AircraftConfigType AircraftConfigurationType { get; set; }
    }
}
