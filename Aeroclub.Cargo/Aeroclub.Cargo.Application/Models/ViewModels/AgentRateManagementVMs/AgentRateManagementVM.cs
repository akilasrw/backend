using Aeroclub.Cargo.Application.Models.Core;

namespace Aeroclub.Cargo.Application.Models.ViewModels.AgentRateManagementVMs
{
    public class AgentRateManagementVM : BaseVM
    {
        public Guid CargoAgentId { get; set; }
        public Guid OriginAirportId { get; set; }
        public Guid DestinationAirportId { get; set; }
        public string OriginAirportCode { get; set; } = null!;
        public string DestinationAirportCode { get; set; } = null!;
        public string OriginAirportName { get; set; } = null!;
        public string DestinationAirportName { get; set; } = null!;
        public string CargoAgentName { get; set; } = null!;
        public IReadOnlyList<AgentRateVM> AgentRates { get; set; }
    }
}
