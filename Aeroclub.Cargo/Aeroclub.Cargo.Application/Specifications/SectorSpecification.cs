using Aeroclub.Cargo.Application.Models.Queries.SectorQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;

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


    }
}