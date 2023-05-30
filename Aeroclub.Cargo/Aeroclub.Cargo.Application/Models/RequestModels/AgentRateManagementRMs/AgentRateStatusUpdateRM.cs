using Aeroclub.Cargo.Application.Models.Core;

namespace Aeroclub.Cargo.Application.Models.RequestModels.AgentRateManagementRMs
{
    public class AgentRateStatusUpdateRM : BaseRM
    {
        public bool IsActive { get; set; }
    }
}
