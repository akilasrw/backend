
namespace Aeroclub.Cargo.Application.Models.Queries.AgentRateManagementQMs
{
    public class AgentRateManagementValidationQM
    {
        public Guid CargoAgentId { get; set; }
        public Guid OriginAirportId { get; set; }
        public Guid DestinationAirportId { get; set; }

    }
}
