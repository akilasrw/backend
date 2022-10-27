

using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.ViewModels.PackageItemVMs
{
    public class PackageItemMobileVM : BaseVM
    {
        public string? FlightNumber { get; set; }
        public DateTime FlightDate { get; set; }
        public string? BookingRefNumber { get; set; }
        public PackageItemCategory PackageItemCategory { get; set; }
        public CargoPositionType CargoPositionType { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public double Height { get; set; }
        public string? VolumeUnit { get; set; }
        public double Weight { get; set; }
        public double ChargeableWeight { get; set; }
        public string? WeightUnit { get; set; }
        public long AwbTrackingNumber { get; set; }
        public string? cargoManifestFilePath { get; set; }

    }
}
