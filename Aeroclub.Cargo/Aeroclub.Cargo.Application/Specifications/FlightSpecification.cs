using System;
using Aeroclub.Cargo.Application.Models.Queries.FlightQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class FlightSpecification : BaseSpecification<Flight>
    {
        public FlightSpecification(FlightQM query)
            : base(x=> 
                        (query.Id == Guid.Empty || x.Id == query.Id) &&
                       ((query.DestinationAirportId == Guid.Empty && query.OriginAirportId == Guid.Empty) && (x.OriginAirportId == query.OriginAirportId && x.DestinationAirportId == query.DestinationAirportId))
            )
        {
            
        }

        public FlightSpecification(FlightListQM query)
        : base(x=> 
            ((query.DestinationAirportId == Guid.Empty && query.OriginAirportId == Guid.Empty) && (x.OriginAirportId == query.OriginAirportId && x.DestinationAirportId == query.DestinationAirportId))
            )
        {
            
        }
    }
}