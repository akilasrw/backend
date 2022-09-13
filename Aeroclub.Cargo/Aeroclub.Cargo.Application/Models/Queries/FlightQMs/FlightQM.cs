using System;
using Aeroclub.Cargo.Application.Models.Core;

namespace Aeroclub.Cargo.Application.Models.Queries.FlightQMs
{
    public class FlightQM : BaseQM
    {
        public string? FlightNumber { get; set; } = null;
        public Guid OriginAirportId { get; set; }
        public Guid DestinationAirportId { get; set; }
        public bool IsIncludeFlightSectors { get; set; }
    }
}