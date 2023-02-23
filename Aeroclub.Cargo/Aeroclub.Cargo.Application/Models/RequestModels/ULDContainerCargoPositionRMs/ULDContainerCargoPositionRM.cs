

namespace Aeroclub.Cargo.Application.Models.RequestModels.ULDContainerCargoPositionRMs
{
    public class ULDContainerCargoPositionRM
    {
        public List<Guid> ULDContainerIds { get; set; } = null!;
        public Guid CargoPositionId { get; set; }
        public double Weight { get; set; }
        public double Volume { get; set; }
    }
}
