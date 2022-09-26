﻿using Aeroclub.Cargo.Core.Entities.Core;

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

        public virtual CargoAgent CargoAgent { get; set; } = null!;
        public virtual Airport OriginAirport { get; set; } = null!;
        public virtual Airport DestinationAirport { get; set; } = null!;
        public virtual ICollection<AgentRate>? AgentRates { get; set; }

    }
}
