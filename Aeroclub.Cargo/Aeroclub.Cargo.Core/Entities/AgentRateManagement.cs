using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class AgentRateManagement : AuditableEntity
    {
        public Guid CargoAgentId { get; set; }
        public Guid OriginAirportId { get; set; }
        public Guid DestinationAirportId { get; set; }
        public string OriginAirportCode { get; set; } = null!;
        public string DestinationAirportCode { get; set; } = null!;
        public string OriginAirportName { get; set; } = null!;
        public string DestinationAirportName { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public RateType RateType { get; set; }
        public CargoType CargoType { get; set; }

        public virtual CargoAgent CargoAgent { get; set; } = null!;
        public virtual Airport OriginAirport { get; set; } = null!;
        public virtual Airport DestinationAirport { get; set; } = null!;
        public virtual ICollection<AgentRate> AgentRates { get; set; } = null!;

    }
}
