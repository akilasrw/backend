using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs
{
    public class FlightScheduleSectorULDPositionCountQM
    {
        public DateTime ScheduledDepartureStartDateTime { get; set; }
        public DateTime ScheduledDepartureEndDateTime { get; set; }
        public bool ExcludeFinalizedSchedules { get; set; }
        
        public ULDLocateStatus ULDLocateStatus { get; set; }
    }
}