using System;
using System.Collections.Generic;
using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class ZoneArea : AuditableEntity
    {
        public string Name { get; set; } = null!;
        public Guid AircraftCabinId { get; set; }
        public double MaxWeight { get; set; }
        public double CurrentWeight { get; set; }
        
        public virtual AircraftCabin AircraftCabin { get; set; }
        public virtual ICollection<CargoPosition> CargoPositions { get; set; }
        public virtual ICollection<Seat> Seats { get; set; }
        public virtual ICollection<OverheadCompartment> OverheadCompartments { get; set; }

    }
}