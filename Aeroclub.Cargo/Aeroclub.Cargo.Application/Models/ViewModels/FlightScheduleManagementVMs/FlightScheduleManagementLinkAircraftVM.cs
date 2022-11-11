using Aeroclub.Cargo.Application.Enums;

namespace Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleManagementVMs
{
    public class FlightScheduleManagementLinkAircraftVM: FlightScheduleManagementVM
    {
        public Guid Id { get; set; }
        public string RegistrationNumber { get; set; } = null!;
        public Guid? AircraftId { get; set; }
        public bool IsAircraftLinked { get; set; } = false;
        public int TotalRecordCount { get; set; }
        public int LinkedAircraftsCount { get; set; }
        public AircaftAssignedStatus Status { get; set; }
    }
}
