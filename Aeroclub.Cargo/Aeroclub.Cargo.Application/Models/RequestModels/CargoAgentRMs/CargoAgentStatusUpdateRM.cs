using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;
using System.ComponentModel.DataAnnotations;


namespace Aeroclub.Cargo.Application.Models.RequestModels.CargoAgentRMs
{
    public class CargoAgentStatusUpdateRM : BaseRM
    {
        [Required(ErrorMessage = "Status required")]
        public CargoAgentStatus Status { get; set; }
    }
}
