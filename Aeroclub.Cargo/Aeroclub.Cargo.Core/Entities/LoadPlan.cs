using System.Collections.Generic;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class LoadPlan : AuditableEntity
    {
        public LoadPlanStatus LoadPlanStatus { get; set; }
        public Guid AircraftLayoutId { get; set; }
        public Guid? SeatLayoutId { get; set; }
        public Guid? OverheadLayoutId { get; set; }

        public virtual AircraftLayout AircraftLayout { get; set; }
        public virtual SeatLayout SeatLayout { get; set; }
        public virtual OverheadLayout OverheadLayout { get; set; }

        public virtual FlightScheduleSector FlightScheduleSector { get; set; }
        public virtual ICollection<ULDContainer> ULDContaines { get; set; }
    }
}