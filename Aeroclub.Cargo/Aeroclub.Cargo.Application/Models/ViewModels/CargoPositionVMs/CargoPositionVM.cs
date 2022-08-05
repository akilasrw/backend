using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.ViewModels.CargoPositionVMs
{
    public class CargoPositionVM : BaseVM
    {
        public string Name { get; set; } = null!;
        public Guid ZoneAreaId { get; set; }
        public CargoPositionType CargoPositionType { get; set; }
        public double MaxWeight { get; set; }
        public double CurrentWeight { get; set; }
        public double MaxVolume { get; set; }
        public double CurrentVolume { get; set; }
        public Guid? SeatId { get; set; }
        public Guid? OverheadCompartmentId { get; set; }
    }
}
