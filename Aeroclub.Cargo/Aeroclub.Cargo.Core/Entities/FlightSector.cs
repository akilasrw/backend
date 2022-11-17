using Aeroclub.Cargo.Core.Entities.Core;
using System;

namespace Aeroclub.Cargo.Core.Entities
{
    public class FlightSector : AuditableEntity
    {
        public Guid FlightId { get; set; }
        public Guid SectorId { get; set; }
        public int Sequence { get; set; }
        public TimeSpan? DepartureDateTime { get; set; }
        public TimeSpan? ArrivalDateTime { get; set; }
        public double? OriginBlockTimeHrs { get; set; }
        public double? DestinationBlockTimeHrs { get; set; }

        public virtual Flight Flight { get; set; }
        public virtual Sector Sector { get; set; }
    }
}