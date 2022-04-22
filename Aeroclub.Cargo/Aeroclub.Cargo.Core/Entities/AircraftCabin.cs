using System;
using System.Collections.Generic;
using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class AircraftCabin : AuditableEntity
    {
        public string Name { get; set; } = null!;
        public Guid AircraftDeckId { get; set; }
        public double MaxWeight { get; set; }
        public double CurrentWeight { get; set; }
        
        public virtual AircraftDeck AircraftDeck { get; set; }
        public virtual ICollection<ZoneArea> CabinAreas { get; set; }
    }
}