using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.ViewModels.PackageItemVMs;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingVMs
{
    public class CargoBookingListVM :BaseVM
    {
        public string BookingNumber { get; set; } = null!;
        public string AWBNumber { get; set; }
        public string BookingAgent { get; set; }
        public DateTime BookingDate { get; set; }
        public BookingStatus BookingStatus { get; set; }
        public VerifyStatus? VerifyStatus { get; set; }
        public int NumberOfBoxes { get; set; }
        public double TotalWeight { get; set; }
        public double TotalVolume { get; set; }
        public int NumberOfRecBoxes { get; set; }
        public double TotalRecWeight { get; set; }
        public double TotalRecVolume { get; set; }

    }

    public class CargoBookingStandByCargoVM : CargoBookingListVM 
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
    }
    
    public class CargoBookingMobileVM : CargoBookingListVM 
    {
        public IReadOnlyList<PackageItemVM> PackageItems { get; set; }
    }
}
