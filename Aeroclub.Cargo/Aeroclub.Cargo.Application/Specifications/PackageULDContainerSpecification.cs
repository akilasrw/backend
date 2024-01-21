using Aeroclub.Cargo.Application.Models.Queries.PackageULDContainerQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class PackageULDContainerSpecification : BaseSpecification<PackageULDContainer>
    {
        public PackageULDContainerSpecification(PackageULDContainerListQM query)
            :base(x => (query.PackageItemId == Guid.Empty || x.PackageItemId == query.PackageItemId))
        {
            AddInclude(x => x.Include(y => y.ULDContainer));
        }

        public PackageULDContainerSpecification(PackageByULDQM query)
            : base(x => (x.ULDContainerId == query.uldContainer))
        {
            AddInclude(x => x.Include(y => y.PackageItem));
        }

    }
}
