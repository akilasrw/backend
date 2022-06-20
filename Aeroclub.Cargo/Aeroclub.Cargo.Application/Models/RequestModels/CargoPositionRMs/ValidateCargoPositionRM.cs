using Aeroclub.Cargo.Application.Models.RequestModels.PackageItemRMs;


namespace Aeroclub.Cargo.Application.Models.RequestModels.CargoPositionRMs
{
    public class ValidateCargoPositionRM
    {
        public Guid FlightScheduleSectorId { get; set; }
        public PackageItemCreateRM PackageItem { get; set; } = null!;
    }
}
