using Aeroclub.Cargo.Application.Models.Queries.ULDContainerCargoPositionQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;


namespace Aeroclub.Cargo.Application.Specifications
{
    public class ULDContainerCargoPositionSpecification : BaseSpecification<ULDContainerCargoPosition>
    {
        public ULDContainerCargoPositionSpecification(ULDCOntainerCargoPositionQM query)
            : base(x => x.CargoPositionId == query.CargoPositionId)
        {
            if (query.IsIncludeULDContainer)
            {
                AddInclude(x => x.Include(y => y.ULDContainer).ThenInclude(a => a.ULD).ThenInclude(b => b.ULDMetaData));
            }
        }

    }
}
