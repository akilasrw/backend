using Aeroclub.Cargo.Application.Models.Queries.SectorQMs;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class SectorSpecification : BaseSpecification<Sector>
    {
        public SectorSpecification(SectorQM query)
            : base(x => ((query.Id == Guid.Empty || x.Id == query.Id) &&
                   (query.DestinationAirportId == Guid.Empty || x.DestinationAirportId == query.DestinationAirportId) &&
                   (query.OriginAirportId == Guid.Empty || x.OriginAirportId == query.OriginAirportId)))
        {

        }

     
        public SectorSpecification(SectorListQM query, bool isCount = false)
            : base(x=>((query.SectorType == SectorType.None ||  x.SectorType == query.SectorType) &&
            (query.DestinationAirportId == Guid.Empty || x.DestinationAirportId == query.DestinationAirportId) &&
            (query.OriginAirportId == Guid.Empty || x.OriginAirportId == query.OriginAirportId) && !x.IsDeleted))
        {
           
            if (!isCount)
            {
                ApplyPaging(query.PageSize * (query.PageIndex - 1), query.PageSize);
                AddOrderByDescending(x => x.Created);
            }

            AddInclude(x => x.Include(y => y.OriginAirport));
            AddInclude(x => x.Include(y => y.DestinationAirport));
        }

        public SectorSpecification(SectorSelectListQM query)
            : base(x => (query.SectorType == SectorType.None || x.SectorType == query.SectorType))
        {

            AddInclude(x => x.Include(y => y.OriginAirport));
            AddInclude(x => x.Include(y => y.DestinationAirport));
        }

        
        public SectorSpecification(Guid flightId):
            base(x => x.FlightSectors.Any(x => x.FlightId == flightId))
        { 

        }


    }
}