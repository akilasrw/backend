using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class FlightSchedule : AuditableEntity
    {
        public Guid? FlightId { get; set; } 
        public string? FlightNumber { get; set; } = null;
        public DateTime ScheduledDepartureDateTime { get; set; }
        public DateTime ActualDepartureDateTime { get; set; }
        public FlightScheduleStatus FlightScheduleStatus { get; set; } = FlightScheduleStatus.None;
        public Guid OriginAirportId { get; set; }
        public Guid DestinationAirportId { get; set; }
        public string OriginAirportCode { get; set; } = null!;
        public string DestinationAirportCode { get; set; } = null!;
        public string OriginAirportName { get; set; } = null!;
        public string DestinationAirportName { get; set; } = null!;
        public Guid? AircraftId { get; set; }
        public string? AircraftRegNo { get; set; } = null;
        public Guid AircraftSubTypeId { get; set; }
        public Guid? FlightScheduleManagementId { get; set; }
        public Guid? AircraftScheduleId { get; set; }

        public virtual Airport? OriginAirport { get; set; }
        public virtual Airport? DestinationAirport { get; set; }
        public virtual Aircraft? Aircraft { get; set; }
        public virtual AircraftSchedule? AircraftSchedule { get; set; }
        public virtual AircraftSubType? AircraftSubType { get; set; }
        public FlightScheduleManagement? FlightScheduleManagement { get; set; }
        public virtual ICollection<FlightScheduleSector> FlightScheduleSectors { get; set; } // For the multiple sectors
    }
}