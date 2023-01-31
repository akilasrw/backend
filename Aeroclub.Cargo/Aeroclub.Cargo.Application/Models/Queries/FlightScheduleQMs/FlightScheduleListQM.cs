using Aeroclub.Cargo.Application.Models.Core;
using System;

namespace Aeroclub.Cargo.Application.Models.Queries.FlightScheduleQMs
{
    public class FlightScheduleListQM :BasePaginationQM
    {
        public Guid OriginAirportId { get; set; }
        public Guid DestinationAirportId { get; set; }
        public DateTime FlightDate { get; set; }
        public bool IncludeAircraftSubType { get; set;}
        public bool IncludeFlightScheduleSectors { get; set;}
    }
}