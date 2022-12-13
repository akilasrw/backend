using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities.Core;


namespace Aeroclub.Cargo.Core.Entities
{
    public class AgentRate : AuditableEntity
    {
        public Guid AgentRateManagementId { get; set; }
        public double Rate { get; set; }
        public WeightType WeightType { get; set; }
        public virtual AgentRateManagement AgentRateManagement { get; set; } = null!;
    }
}
