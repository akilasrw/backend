using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class FlightSchedule : AuditableEntity
    {
        public Guid? FlightId { get; set; } 
        public string? FlightNumber { get; set; } = null;
        public DateTime ScheduledDepartureDateTime { get; set; }
        public DateTime? EstimatedDepartureDateTime { get; set; }
        public DateTime? EstimatedArrivalDateTime { get; set; }
        public DateTime ActualDepartureDateTime { get; set; }
        public DateTime? ActualArrivalDateTime { get; set; }
        public FlightScheduleStatus FlightScheduleStatus { get; set; } = FlightScheduleStatus.None;
        public FlightScheduleOrderStatus FlightScheduleOrderStatus { get; set; } = FlightScheduleOrderStatus.None;
        public Guid OriginAirportId { get; set; }
        public Guid DestinationAirportId { get; set; }
        public string OriginAirportCode { get; set; } = null!;
        public string DestinationAirportCode { get; set; } = null!;
        public string OriginAirportName { get; set; } = null!;
        public string DestinationAirportName { get; set; } = null!;
        public Guid? AircraftId { get; set; }
        public string? AircraftRegNo { get; set; } = null;
        public Guid? AircraftSubTypeId { get; set; }
        public Guid? FlightScheduleManagementId { get; set; }
        public Guid? AircraftScheduleId { get; set; }
        public bool IsHistory { get; set; } = false; // this will be true when updated 'ActualDepartureDateTime'
        public bool IsDispatched { get; set; } = false;
        public double CutoffTimeMin { get; set; } = 720.00;

        public virtual Airport? OriginAirport { get; set; }
        public virtual Airport? DestinationAirport { get; set; }
        public virtual Aircraft? Aircraft { get; set; }
        public virtual AircraftSchedule? AircraftSchedule { get; set; }
        public virtual AircraftSubType? AircraftSubType { get; set; }
        public FlightScheduleManagement? FlightScheduleManagement { get; set; }
        public LIRFileUpload? LIRFileUpload { get; set; }
        public virtual ICollection<FlightScheduleSector> FlightScheduleSectors { get; set; } // For the multiple sectors
    }
}