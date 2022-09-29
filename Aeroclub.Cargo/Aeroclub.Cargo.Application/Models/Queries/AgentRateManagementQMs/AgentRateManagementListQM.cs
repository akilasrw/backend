using Aeroclub.Cargo.Application.Models.Core;

namespace Aeroclub.Cargo.Application.Models.Queries.AgentRateManagementQMs
{
    public class AgentRateManagementListQM : BasePaginationQM
    {
        public Guid CargoAgentId { get; set; }
        public Guid OriginAirportId { get; set; }
        public Guid DestinationAirportId { get; set; }
    }
}
