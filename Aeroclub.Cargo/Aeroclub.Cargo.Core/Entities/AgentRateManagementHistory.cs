using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class AgentRateManagementHistory : AuditableEntity 
    {
        public Guid? CargoAgentId { get; set; }
        public Guid OriginAirportId { get; set; }
        public Guid DestinationAirportId { get; set; }
        public string OriginAirportCode { get; set; } = null!;
        public string DestinationAirportCode { get; set; } = null!;
        public string OriginAirportName { get; set; } = null!;
        public string DestinationAirportName { get; set; } = null!;
        public RateType RateType { get; set; }
        public CargoType CargoType { get; set; }
        public double Rate { get; set; }
        public WeightType WeightType { get; set; }
        public string CreatedUser { get; set; } = null!;
        public DBTransactionStatus Status { get; set; }

    }
}
