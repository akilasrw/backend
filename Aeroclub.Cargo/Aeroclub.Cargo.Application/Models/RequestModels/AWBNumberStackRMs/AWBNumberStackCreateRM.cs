using System.ComponentModel.DataAnnotations;

namespace Aeroclub.Cargo.Application.Models.RequestModels.AWBNumberStackRMs
{
    public class AWBNumberStackCreateRM
    {
        [Required(ErrorMessage = "AWB number required")]
        public long AWBTrackingNumber { get; set; }

        [Required(ErrorMessage = "Used status required")]
        public bool IsUsed { get; set; } = false;

        [Required(ErrorMessage = "Cargo agent Id required")]
        public Guid CargoAgentId { get; set; }
    }
}
