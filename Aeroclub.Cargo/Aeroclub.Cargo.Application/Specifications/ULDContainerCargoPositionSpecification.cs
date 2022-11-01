using Aeroclub.Cargo.Application.Models.Queries.ULDContainerCargoPositionQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;


namespace Aeroclub.Cargo.Application.Specifications
{
    public class ULDContainerCargoPositionSpecification : BaseSpecification<ULDContainerCargoPosition>
    {
        public ULDContainerCargoPositionSpecification(ULDCOntainerCargoPositionQM query)
            : base(x => (query.CargoPositionId == Guid.Empty || x.CargoPositionId == query.CargoPositionId) &&
                        (query.CargoPositionId == Guid.Empty || x.ULDContainerId == query.ULDContainerId))
        {
            if (query.IsIncludeULDContainer)
                AddInclude(x => x.Include(y => y.ULDContainer).ThenInclude(a => a.ULD).ThenInclude(b => b.ULDMetaData));
            
            if (query.IsIncludeCargoPosition)
                AddInclude(x => x.Include(y => y.CargoPosition));

        }

    }
}
