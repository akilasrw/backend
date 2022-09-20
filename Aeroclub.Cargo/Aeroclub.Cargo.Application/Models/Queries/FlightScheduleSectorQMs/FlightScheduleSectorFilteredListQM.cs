using System;
using System.Text.Json.Serialization;
using Aeroclub.Cargo.Application.Models.Core;

namespace Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs
{
    public class FlightScheduleSectorFilteredListQM : BasePaginationQM
    {
        public Guid OriginAirportId { get; set; }
        public Guid DestinationAirportId { get; set; }
        public DateTime ScheduledDepartureDateTime { get; set; }
        public DateTime ScheduledDepartureStartDateTime { get; set; }
        public DateTime ScheduledDepartureEndDateTime { get; set; }
        [JsonIgnore]
        public bool OriginAirportOnly { get; set; } = false;
        [JsonIgnore]
        public bool DestinationAirportOnly { get; set; } = false;
        [JsonIgnore]
        public bool IncludeAircraftSubType { get; set; } = false;

    }
}