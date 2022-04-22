using System;

namespace Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs
{
    public class FlightScheduleSectorListQM
    {
        public Guid OriginAirportId { get; set; }
        public Guid DestinationAirportId { get; set; }
        public DateTime ScheduledDepartureDateTime { get; set; }
        public DateTime ScheduledDepartureStartDateTime { get; set; }
        public DateTime ScheduledDepartureEndDateTime { get; set; }
        public bool OriginAirportOnly { get; set; } = false;
    }
}