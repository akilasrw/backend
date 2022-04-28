using System.Collections.Generic;
using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class AircraftLayout : AuditableEntity
    {
        public virtual ICollection<AircraftDeck> AircraftDecks { get; set; }
        public bool IsBaseLayout { get; set; } = false;
    }
}