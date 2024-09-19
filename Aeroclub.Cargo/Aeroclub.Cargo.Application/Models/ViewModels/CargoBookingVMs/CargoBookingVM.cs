
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingVMs
{
    public class CargoBookingVM : BaseVM
    {
        public string BookingNumber { get; set; } = null!;
        public string AWBNumber { get; set; }
        public DateTime BookingDate { get; set; }
        public Guid DestinationAirportId { get; set; }
        public string DestinationAirportCode { get; set; }
        public string FlightNumber { get; set; }
        public DateTime FlightDate { get; set; }
        public int NumberOfBoxes { get; set; }
        public double TotalWeight { get; set; }
        public int? shipmentCount { get; set; }
        public AircraftConfigType AircraftConfigType { get; set; }
        public PackageItemStatus BookingStatus { get; set; }
        public AWBStatus AWBStatus { get; set; }
        public string AgentName {  get; set; } 


    }
}
