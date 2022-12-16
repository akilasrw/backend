
namespace Aeroclub.Cargo.Application.Models.Queries.AgentRateManagementQMs
{
    public class AgentRateManagementUpdateQM
    {
        public Guid CargoAgentId { get; set; }
        public Guid OriginAirportId { get; set; }
        public Guid DestinationAirportId { get; set; }
        public DateTime ValidStartDate { get; set; }
        public DateTime ValidEndDate { get; set; }
        public bool IncludeAgentRates { get; set; }

    }
    
}
