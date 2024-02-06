using Aeroclub.Cargo.Application.Models.Queries.ULDContainerQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class ULDContainerSpecification : BaseSpecification<ULDContainer>
    {
        public ULDContainerSpecification(ULDContainerQM query)
            :base(x=>x.Id == query.Id)
        {
            AddInclude(y => y.Include(y => y.PackageULDContainers).ThenInclude(z=>z.PackageItem));
        }

        public ULDContainerSpecification(Guid uldId)
            :base(x => x.ULDId == uldId)
        {

        }
    }
}
