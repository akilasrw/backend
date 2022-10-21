using Aeroclub.Cargo.Application.Models.Core;
using System.ComponentModel.DataAnnotations;

namespace Aeroclub.Cargo.Application.Models.RequestModels.AWBNumberStackRMs
{
    public class AWBNumberStackUpdateRM : BaseRM
    {
        [Required(ErrorMessage = "AWB number required")]
        public long AWMTrackingNumber { get; set; }

        [Required(ErrorMessage = "Used status required")]
        public bool IsUsed { get; set; } = false;

        [Required(ErrorMessage = "Cargo agent Id required")]
        public Guid CargoAgentId { get; set; }
    }
}
