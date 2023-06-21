using Aeroclub.Cargo.Application.Enums;

namespace Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleManagementVMs
{
    public class FlightScheduleLinkAircraftVM
    {
        public Guid Id { get; set; }
        public string? FlightNumber { get; set; } = null;
        public Guid? AircraftId { get; set; }
        public DateTime ScheduledDepartureDateTime { get; set; }
        public DateTime? ScheduledArrivalDateTime { get; set; }
        public DateTime? EstimatedDepartureDateTime { get; set; }
        public DateTime? EstimatedArrivalDateTime { get; set; }
        public DateTime ActualDepartureDateTime { get; set; }
        public DateTime? ActualArrivalDateTime { get; set; }
        public string? AircraftRegNo { get; set; } = null;
        public double? BlockHrs { get; set; }
        public string OriginAirportName { get; set; } = null!;
        public string DestinationAirportName { get; set; } = null!;
        public string AircraftSubTypeName { get; set; }
        public double TotalWeight { get; set; }
        public bool IsHistory { get; set; }
        public bool IsDispatched { get; set; }
        public int OffLoadCount { get; set; }
        public int ActualLoadCount { get; set; }
    }
}
