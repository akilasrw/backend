using System;
using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class Seat : AuditableEntity
    {
        public string SeatNumber { get; set; } = null!;
        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }
        public Guid ZoneAreaId { get; set; }
        public Guid SeatConfigurationId { get; set; }
        public bool IsOnSeatOccupied { get; set; }
        public bool IsUnderSeatOccupied { get; set; }
        
        public virtual ZoneArea ZoneArea { get; set; }
        public virtual SeatConfiguration SeatConfiguration { get; set; }
    }
}