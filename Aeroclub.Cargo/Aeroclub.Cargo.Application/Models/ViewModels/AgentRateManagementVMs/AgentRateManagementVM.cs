using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;

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
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public RateType RateType { get; set; }
        public CargoType CargoType { get; set; }
        public IReadOnlyList<AgentRateVM> AgentRates { get; set; }
        public bool IsActive { get; set; }

    }
}
