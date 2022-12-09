using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.ViewModels.ULDCargoBookingVMs
{
    public class ULDCargoBookingListVM
    {
        public string BookingNumber { get; set; } = null!;
        public string? AWBNumber { get; set; }
        public string? BookingAgent { get; set; }
        public int NumberOfAssignedBoxes { get; set; }
        public int NumberOfBoxes { get; set; }
        public double TotalWeight { get; set; }
        public double TotalVolume { get; set; }
    }
}
