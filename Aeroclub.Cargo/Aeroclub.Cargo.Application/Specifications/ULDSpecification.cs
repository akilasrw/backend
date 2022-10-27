using Aeroclub.Cargo.Application.Models.Queries.ULDQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class ULDSpecification: BaseSpecification<ULD>
    {
        public ULDSpecification(ULDQM query)
            :base(x=> (query.Id == Guid.Empty || x.Id == query.Id) &&
                query.PositionId == Guid.Empty || x.ULDCargoPosition.CargoPositionId == query.PositionId)
        {
            AddInclude(y => y.Include(z => z.ULDCargoPosition).ThenInclude(c => c.CargoPosition));
            AddInclude(y => y.Include(z => z.ULDMetaData));
        }
    }
}
