
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.ViewModels.AirWayBillVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleSectorVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.PackageItemVMs;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingLookupVMs
{
    public class CargoBookingLookupVM :BaseVM
    {
        public string BookingNumber { get; set; } = null!;
        public DateTime BookingDate { get; set; }
        public BookingStatus BookingStatus { get; set; }
        public AWBStatus AWBStatus { get; set; }
        public string? FlightNumber { get; set; }
        public string OriginAirportCode { get; set; } = null!;
        public string DestinationAirportCode { get; set; } = null!;
        public DateTime ScheduledDepartureDateTime { get; set; }
        public AWBInformationVM? AWBInformation { get; set; }
        public IReadOnlyList<PackageItemVM> PackageItems { get; set; }
    }
}
