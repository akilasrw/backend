using Aeroclub.Cargo.Application.Models.RequestModels.PackageItemRMs;


namespace Aeroclub.Cargo.Application.Models.RequestModels.CargoPositionRMs
{
    public class ValidateCargoPositionRM
    {
        public IList<Guid> FlightScheduleSectorIds { get; set; } = null!;
        public PackageItemCreateRM PackageItem { get; set; } = null!;
    }
}
