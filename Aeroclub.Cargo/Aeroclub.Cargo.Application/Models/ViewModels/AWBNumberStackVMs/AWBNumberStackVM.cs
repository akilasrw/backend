

using Aeroclub.Cargo.Application.Models.Core;

namespace Aeroclub.Cargo.Application.Models.ViewModels.AWBNumberStackVMs
{
    public class AWBNumberStackVM : BaseVM
    {
        public long AWBTrackingNumber { get; set; }
        public bool IsUsed { get; set; } = false;
        public string CargoAgentName { get; set; } = null!;
        public Guid CargoAgentId { get; set; }
    }
}
