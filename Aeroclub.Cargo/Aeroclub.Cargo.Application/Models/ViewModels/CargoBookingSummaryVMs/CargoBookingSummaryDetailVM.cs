using Aeroclub.Cargo.Application.Models.ViewModels.CargoPositionVMs;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingSummaryVMs
{
    public class CargoBookingSummaryDetailVM
    {
        public string FlightNumber { get; set; } = null!;
        public DateTime ScheduledDepartureDateTime { get; set; }
        public string OriginAirportCode { get; set; } = null!;
        public string DestinationAirportCode { get; set; } = null!;
        public string OriginAirportName { get; set; } = null!;
        public string DestinationAirportName { get; set; } = null!;
        public string AircraftRegNo { get; set; } = null!;
        public AircraftConfigType AircraftConfigurationType { get; set; }
        public AircraftSubTypes AircraftSubType { get; set; }
        public CargoPositionSummaryVM CargoPositionSummary { get; set; }
        public IReadOnlyList<CargoPositionDetailVM> CargoPositions { get; set; }
    }
}
