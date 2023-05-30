using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleManagementVMs;

namespace Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleVMs
{
    public class FlightScheduleLinkVM : FlightScheduleLinkAircraftVM
    {
        public int AcutalLoadBookingCount { get; set; }
        public int OffLoadBookingCount { get; set; }
        public bool IsDispatched { get; set; }
    }
}
