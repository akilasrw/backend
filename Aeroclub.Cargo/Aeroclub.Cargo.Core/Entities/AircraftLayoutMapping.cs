using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class AircraftLayoutMapping : AuditableEntity
    {
        public Guid AircraftTypeId { get; set; }
        public Guid AircraftSubTypeId { get; set; }
        public Guid? AircraftLayoutId { get; set; }
        public Guid? SeatLayoutId { get; set; }
        public Guid? OverheadLayoutId { get; set; }

        public virtual AircraftLayout AircraftLayout { get; set; }
        public virtual SeatLayout SeatLayout { get; set; }
        public virtual OverheadLayout OverheadLayout { get; set; }
        public virtual AircraftType AircraftType { get; set; }
        public virtual AircraftSubType AircraftSubType { get; set; }

    }
}
