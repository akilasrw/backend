using Aeroclub.Cargo.Application.Models.Core;

namespace Aeroclub.Cargo.Application.Models.Queries.FlightScheduleQMs
{
    public class FlightScheduleQM: BaseQM
    {
        public Guid FlightId { get; set; }
        public bool IncludeFlightScheduleSectors { get; set; }
    }
}
