using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.ViewModels.AgentRateManagementVMs
{
    public class AgentRateVM : BaseVM
    {
        public Guid AgentRateManagementId { get; set; }
        public double Rate { get; set; }
        public WeightType WeightType { get; set; }
    }
}
