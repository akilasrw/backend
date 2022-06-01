
using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class ULDContainerCargoPosition : BaseEntity
    {
        public Guid ULDContainerId { get; set; }
        public Guid CargoPositionId { get; set; }

        public virtual ULDContainer ULDContainer { get; set; }
        public virtual CargoPosition CargoPosition { get; set; }
    }
}
