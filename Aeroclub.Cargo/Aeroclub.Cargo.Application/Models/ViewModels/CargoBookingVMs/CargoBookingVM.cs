
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingVMs
{
    public class CargoBookingVM : BaseVM
    {
        public string BookingNumber { get; set; } = null!;
        public DateTime BookingDate { get; set; }
        public Guid DestinationAirportId { get; set; }
        public string DestinationAirportCode { get; set; }
        public string FlightNumber { get; set; }
        public DateTime FlightDate { get; set; }
        public int NumberOfBoxes { get; set; }
        public double TotalWeight { get; set; }
        public BookingStatus BookingStatus { get; set; }
        public AWBStatus AWBStatus { get; set; }


    }
}
