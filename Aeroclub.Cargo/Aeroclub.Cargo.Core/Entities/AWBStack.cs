
using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class AWBStack : AuditableEntity
    {
        public int StartSequenceNumber { get; set; }
        public int EndSequenceNumber { get; set; }
        public int LastUsedSequenceNumber { get; set; }
        public bool IsSequenceCompleted { get; set; } = false;
        public Guid CargoAgentId { get; set; }

        public virtual CargoAgent CargoAgent { get; set; }

    }
}
