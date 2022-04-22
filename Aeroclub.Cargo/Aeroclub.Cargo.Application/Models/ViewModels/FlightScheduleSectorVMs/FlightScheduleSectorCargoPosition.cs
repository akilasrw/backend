using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleSectorVMs
{
    public class FlightScheduleSectorCargoPosition
    {
        public CargoPositionType CargoPositionType { get; set; }
        public int AvailableSpaceCount { get; set; }
    }
}