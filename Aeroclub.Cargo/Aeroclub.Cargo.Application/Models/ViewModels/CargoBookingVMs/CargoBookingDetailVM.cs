using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.ViewModels.AirWayBillVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleSectorVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.PackageItemVMs;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingVMs
{
    public class CargoBookingDetailVM : BaseVM
    {
        public string BookingNumber { get; set; } = null!;
        public DateTime BookingDate { get; set; }
        public BookingStatus BookingStatus { get; set; }
        public FlightScheduleSectorVM FlightScheduleSector { get; set; }
        public AWBInformationVM? AWBInformation { get; set; }
        public IReadOnlyList<PackageItemVM> PackageItems { get; set; }

    }
}
