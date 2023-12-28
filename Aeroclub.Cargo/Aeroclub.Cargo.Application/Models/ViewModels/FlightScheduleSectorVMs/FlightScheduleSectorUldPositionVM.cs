using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleSectorVMs
{
    public class FlightScheduleSectorUldPositionVM
    {
        public Guid Id { get; set; }
        public string? FlightNumber { get; set; } = null;
        public DateTime ScheduledDepartureDateTime { get; set; }
        public string OriginAirportCode { get; set; } = null!;
        public string DestinationAirportCode { get; set; } = null!;
        public string? AircraftSubTypeName { get; set; }
        public Guid? AircraftLayoutId { get; set; }
        public DateTime? CutoffTime { get; set; }
        public int ULDPositionCount { get; set; }
        public AircraftTypes? AircraftType { get; set; }
        public int ULDCount { get; set; }

    }
}