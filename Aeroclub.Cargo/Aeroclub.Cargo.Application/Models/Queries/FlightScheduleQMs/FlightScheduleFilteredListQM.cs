using Aeroclub.Cargo.Application.Models.Core;
using System.Text.Json.Serialization;

namespace Aeroclub.Cargo.Application.Models.Queries.FlightScheduleQMs
{
    public class FlightScheduleFilteredListQM : BasePaginationQM
    {
        public Guid OriginAirportId { get; set; }
        public Guid DestinationAirportId { get; set; }
        public string? FlightNumber { get; set; }

        [JsonIgnore]
        public bool IncludeAircraft { get; set; } = false;

    }
}
