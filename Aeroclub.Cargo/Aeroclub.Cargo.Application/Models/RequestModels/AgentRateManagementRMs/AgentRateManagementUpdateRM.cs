using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoAgentRateRMs;
using Aeroclub.Cargo.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace Aeroclub.Cargo.Application.Models.RequestModels.AgentRateManagementRMs
{
    public class AgentRateManagementUpdateRM : BaseRM
    {
        public Guid? CargoAgentId { get; set; }

        [Required(ErrorMessage = "Origin airport required.")]
        public Guid OriginAirportId { get; set; }

        [Required(ErrorMessage = "Destination airport required.")]
        public Guid DestinationAirportId { get; set; }
        [Required(ErrorMessage = "Start Date required.")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "End Date required.")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Rate type required.")]
        public RateType RateType { get; set; }

        [Required(ErrorMessage = "Cargo type required.")]
        public CargoType CargoType { get; set; }

        [Required(ErrorMessage = "Rate(s) required.")]
        public IEnumerable<AgentRateRM> AgentRates { get; set; } = null!;
        public bool IsActive { get; set; }

    }
}
