using System;

namespace Aeroclub.Cargo.Application.Models.Queries.FlightQMs
{
    public class FlightListQM
    {
        public Guid OriginAirportId { get; set; }
        public Guid DestinationAirportId { get; set; }
    }
}