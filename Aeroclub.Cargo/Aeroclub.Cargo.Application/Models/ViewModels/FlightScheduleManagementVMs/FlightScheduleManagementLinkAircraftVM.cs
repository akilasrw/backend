namespace Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleManagementVMs
{
    public class FlightScheduleManagementLinkAircraftVM: FlightScheduleManagementVM
    {
        public Guid Id { get; set; }
        public string RegistrationNumber { get; set; } = null!;
        public Guid? AircraftId { get; set; }
        public bool IsAircraftLinked { get; set; } = false;
    }
}
