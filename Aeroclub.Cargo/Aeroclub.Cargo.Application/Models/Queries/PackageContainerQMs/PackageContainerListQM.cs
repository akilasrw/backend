using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.Queries.PackageContainerQMs
{
    public class PackageContainerListQM: BaseQM
    {
        public PackageItemCategory PackageItemCategory { get; set; }
        public PackageBoxType PackageBoxType { get; set; } = PackageBoxType.Container;
    }
}
