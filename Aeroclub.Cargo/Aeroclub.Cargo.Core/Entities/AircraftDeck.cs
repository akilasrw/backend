using System;
using System.Collections.Generic;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class AircraftDeck : AuditableEntity
    {
        public AircraftDeckType AircraftDeckType { get; set; }
        public double MaxWeight { get; set; }
        public double CurrentWeight { get; set; }
        public Guid AircraftLayoutId { get; set; }
        
        public virtual AircraftLayout AircraftLayout { get; set; }
        public virtual ICollection<AircraftCabin> AircraftCabins { get; set; }
    }
}