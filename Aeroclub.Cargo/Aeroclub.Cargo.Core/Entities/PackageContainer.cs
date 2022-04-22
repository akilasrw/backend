using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class PackageContainer : AuditableEntity
    {
        public double? Height { get; set; } = null;
        public double? Width { get; set; } = null;
        public double? Length { get; set; } = null;
        public bool IsCustom { get; set; } = false;
        public PackageContainerType? PackageContainerType { get; set; }
        public PackageItemCategory PackageItemCategory { get; set; }
        public PackageBoxType PackageBoxType { get; set; } = PackageBoxType.Container;
        public double MaxWaight { get; set; } 
        public double ? MinWaight { get; set; } = null;


        public virtual ICollection<PackageContainerSector> PackageContainerSector { get; set; }

    }
}
