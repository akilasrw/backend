using Aeroclub.Cargo.Application.Models.Queries.PackageContainerQMs;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class PackageContainerSpecification : BaseSpecification<PackageContainer>
    {
        public PackageContainerSpecification(PackageContainerListQM query)
            : base(x=> (query.PackageItemCategory == PackageItemCategory.None || x.PackageItemCategory == query.PackageItemCategory) && 
            x.PackageBoxType == query.PackageBoxType)
        {

        }
    }
}
