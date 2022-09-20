using Aeroclub.Cargo.Application.Models.Core;

namespace Aeroclub.Cargo.Application.Models.Queries.CargoBookingSummaryQMs
{
    public class CargoBookingSummaryDetailQM : BaseQM
    {
        public bool IsIncludeAircraftType { get; set; }
        public bool IsIncludeFlightScheduleSectors { get; set; }
    }
}
