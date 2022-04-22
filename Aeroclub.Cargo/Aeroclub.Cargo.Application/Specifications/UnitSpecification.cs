

using Aeroclub.Cargo.Application.Models.Queries.UnitQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class UnitSpecification : BaseSpecification<Unit>
    {
        public UnitSpecification(UnitQM query)
            : base(x=> (query.Id == Guid.Empty || x.Id == query.Id) && (query.UnitType == Common.Enums.UnitType.None || x.UnitType == query.UnitType))
        {

        }
    }
}
