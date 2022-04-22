
using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class PackageContainerSector : BaseEntity
    {
        public Guid PackageContainerId { get; set; }
        public Guid SectorId { get; set; }
        public double Rate { get; set; }

        public virtual Sector Sector { get; set; }
        public virtual PackageContainer PackageContainer { get; set; }
    }
}
