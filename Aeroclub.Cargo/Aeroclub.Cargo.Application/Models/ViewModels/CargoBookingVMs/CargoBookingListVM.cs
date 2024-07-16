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
        public string? CargoHandlingInstruction { get; set; }
        public IReadOnlyList<PackageMobileVMs>? PackageItems { get; set; }

    }

    public class CargoBookingStandByCargoVM : BaseQM
    {
        public string Origin { get; set; }
        public string Destination { get; set; }

        public string BookingNumber { get; set; } = null!;
        public string AWBNumber { get; set; }
        public string BookingAgent { get; set; }
        public DateTime BookingDate { get; set; }
        public PackageItemStatus BookingStatus { get; set; }
        public VerifyStatus? VerifyStatus { get; set; }
        public int NumberOfBoxes { get; set; }
        public double TotalWeight { get; set; }
        public double TotalVolume { get; set; }
        public int NumberOfRecBoxes { get; set; }
        public double TotalRecWeight { get; set; }
        public double TotalRecVolume { get; set; }
        public string? CargoHandlingInstruction { get; set; }
        public IReadOnlyList<PackageMobileVMs>? PackageItems { get; set; }
    }
    
    public class CargoBookingMobileVM : CargoBookingStandByCargoVM
    {
        public string? FlightNumber { get; set; }
        public DateTime ScheduledDepartureDateTime { get; set; }
        public string? AircraftSubTypeName { get; set; }
        public double? CutoffTimeMin { get; set; }
        public IReadOnlyList<PackageMobileVMs> PackageItems { get; set; }
    }
}
