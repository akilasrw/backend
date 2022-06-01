using System.Collections.Generic;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class SeatConfiguration : AuditableEntity
    {
        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }
        public SeatConfigurationType SeatConfigurationType { get; set; }
        public bool IsOnSeatOccupied { get; set; }
        public bool IsUnderSeatOccupied { get; set; }
        public bool IsFullRowOccupied { get; set; }
        public double MaxWeight { get; set; }
        public Guid? SeatLayoutId { get; set; }

        public virtual ICollection<Seat> Seats { get; set; }
        public virtual SeatLayout SeatLayout { get; set; }
    }
}