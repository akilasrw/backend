using System;
using Aeroclub.Cargo.Application.Models.Queries.FlightQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class FlightSpecification : BaseSpecification<Flight>
    {
        public FlightSpecification(FlightQM query)
            : base(x=> 
                        (query.Id == Guid.Empty || x.Id == query.Id) &&
                       ((query.DestinationAirportId == Guid.Empty && query.OriginAirportId == Guid.Empty) || (x.OriginAirportId == query.OriginAirportId && x.DestinationAirportId == query.DestinationAirportId))
            )
        {
            if (query.IncludeSectors)
                AddInclude(x => x.Include(y => y.FlightSectors).ThenInclude(z => z.Sector));
        }
        
        public FlightSpecification(FlightListQM query)
        : base(x=> 
            ((query.DestinationAirportId == Guid.Empty && query.OriginAirportId == Guid.Empty) && (x.OriginAirportId == query.OriginAirportId && x.DestinationAirportId == query.DestinationAirportId))
            )
        {
            
        }

        public FlightSpecification(FlightDetailQM query)
           : base(x =>x.Id == query.Id 
           )
        {
            if (query.IsIncludeFlightSectors)
                AddInclude(x => x.Include(y => y.FlightSectors).ThenInclude(z => z.Sector).ThenInclude((x)=> x.OriginAirport));
                AddInclude(x => x.Include(y => y.FlightSectors).ThenInclude(z => z.Sector).ThenInclude((x) => x.DestinationAirport));
        }

        public FlightSpecification(FlightFilterListQM query, bool isCount = false)
            : base(x => ((string.IsNullOrEmpty(query.FlightNumber) || x.FlightNumber.Contains(query.FlightNumber)) &&
            (query.DestinationAirportId == Guid.Empty || x.DestinationAirportId == query.DestinationAirportId) &&
            (query.OriginAirportId == Guid.Empty || x.OriginAirportId == query.OriginAirportId) && !x.IsDeleted))
        {

            if (!isCount)
            {
                AddInclude(y => y.Include(z => z.FlightSectors));
                ApplyPaging(query.PageSize * (query.PageIndex - 1), query.PageSize);
                AddOrderByDescending(x => x.Created);
            }
        }

        public FlightSpecification(FlightCheckExistsQM query)
            : base(x => x.FlightNumber.ToUpper() == query.FlightNumber.Trim().ToUpper())
        {

        }
    }
}