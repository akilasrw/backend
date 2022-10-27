using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class AWBNumberStack : AuditableEntity
    {
        public long AWBTrackingNumber { get; set; }
        public bool IsUsed { get; set; } = false;
        public Guid CargoAgentId { get; set; }

        public virtual CargoAgent CargoAgent { get; set; }

    }
}
