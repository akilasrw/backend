using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.ViewModels.PackageListItemVM
{
    public class PackageListItemVM : BaseVM
    {
        public string PackageRefNumber { get; set; } = null!;
        public string FlightNumber { get; set; }
        public DateTime BookingDate { get; set; }
        public PackageItemStatus packageItemStatus { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public double Weight { get; set; }
        public double ChargeableWeight { get; set; }
    }
}
