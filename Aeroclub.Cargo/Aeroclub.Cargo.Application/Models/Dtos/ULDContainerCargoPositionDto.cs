

namespace Aeroclub.Cargo.Application.Models.Dtos
{
    public class ULDContainerCargoPositionDto
    {
        public Guid ULDContainerId { get; set; }
        public Guid CargoPositionId { get; set; }
        public double Weight { get; set; }
        public double Volume { get; set; }

    }
}
