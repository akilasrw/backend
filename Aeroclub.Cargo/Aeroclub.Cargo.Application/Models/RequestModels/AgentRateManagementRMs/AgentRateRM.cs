
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.RequestModels.AgentRateManagementRMs;
using Aeroclub.Cargo.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace Aeroclub.Cargo.Application.Models.RequestModels.CargoAgentRateRMs
{
    public class AgentRateRM :BaseRM
    {     
        public Guid AgentRateManagementId { get; set; }

        [Required(ErrorMessage = "Rate required.")]
        public double Rate { get; set; }

        [Required(ErrorMessage = "Weight type required.")]
        public WeightType WeightType { get; set; }

    }
}
