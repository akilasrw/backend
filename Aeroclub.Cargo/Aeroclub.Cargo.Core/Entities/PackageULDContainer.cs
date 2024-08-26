using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class PackageULDContainer: BaseEntity
    {
        public Guid PackageItemId { get; set; }
        public Guid ULDContainerId { get; set; }
        public bool IsDeleted { get; set; }

        public virtual PackageItem PackageItem { get; set; }
        public virtual ULDContainer ULDContainer { get; set; }
    }
}
