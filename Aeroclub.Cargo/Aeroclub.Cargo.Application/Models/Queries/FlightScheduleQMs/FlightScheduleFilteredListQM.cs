using Aeroclub.Cargo.Application.Models.Core;

namespace Aeroclub.Cargo.Application.Models.Queries.FlightScheduleQMs
{
    public class FlightScheduleFilteredListQM : BasePaginationQM
    {
        public Guid OriginAirportId { get; set; }
        public Guid DestinationAirportId { get; set; }
        public DateTime ScheduledDepartureDateTime { get; set; }

    }
}