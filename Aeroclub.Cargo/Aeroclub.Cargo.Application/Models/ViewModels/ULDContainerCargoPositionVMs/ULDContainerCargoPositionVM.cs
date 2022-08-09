using Aeroclub.Cargo.Application.Models.ViewModels.CargoPositionVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.ULDContainerVMs;

namespace Aeroclub.Cargo.Application.Models.ViewModels.ULDContainerCargoPositionVMs
{
    public class ULDContainerCargoPositionVM
    {
        public Guid ULDContainerId { get; set; }
        public Guid CargoPositionId { get; set; }

        public ULDContainerVM ULDContainer { get; set; }
        public CargoPositionVM CargoPosition { get; set; }


    }
}
