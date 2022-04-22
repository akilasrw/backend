using Aeroclub.Cargo.Application.Models.Core;

namespace Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs
{
    public class FlightScheduleSectorQM : BaseQM
    {
        public bool IncludeULDContaines { get; set; }
        public bool IncludeAircraft { get; set; }
        public bool IncludeLoadPlan { get; set; }
    }
}