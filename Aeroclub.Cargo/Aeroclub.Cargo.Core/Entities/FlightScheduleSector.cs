using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class FlightScheduleSector : AuditableEntity
    {
        public Guid FlightId { get; set; }
        public Guid SectorId { get; set; }
        public Guid FlightScheduleId { get; set; }
        public int SequenceNo { get; set; }
        public DateTime ScheduledDepartureDateTime { get; set; }
        public DateTime? EstimatedDepartureDateTime { get; set; }
        public DateTime? EstimatedArrivalDateTime { get; set; }
        public DateTime? ActualArrivalDateTime { get; set; }
        public DateTime ActualDepartureDateTime { get; set; }
        public FlightScheduleStatus FlightScheduleStatus { get; set; } = FlightScheduleStatus.None;
        public Guid OriginAirportId { get; set; }
        public Guid DestinationAirportId { get; set; }
        public string OriginAirportCode { get; set; } = null!;
        public string DestinationAirportCode { get; set; } = null!;
        public string OriginAirportName { get; set; } = null!;
        public string DestinationAirportName { get; set; } = null!;
        public string? FlightNumber { get; set; } = null;
        public Guid? LoadPlanId { get; set; } = null;
        public Guid? AircraftId { get; set; } = null;
        public Guid AircraftSubTypeId { get; set; }

        public virtual Flight Flight { get; set; }
        public virtual Sector Sector { get; set; }
        public virtual FlightSchedule FlightSchedule { get; set; }
        public virtual LoadPlan LoadPlan { get; set; }
        public virtual Aircraft Aircraft { get; set; }
        public virtual AircraftSubType AircraftSubType { get; set; }
        public virtual ICollection<CargoBookingFlightScheduleSector> CargoBookingFlightScheduleSectors { get; set; }

    }
}