using System.Collections.Generic;
using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class SeatLayout : AuditableEntity
    {
        public bool IsCloned { get; set; }
        public bool IsBaseLayout { get; set; } = false;
        public virtual ICollection<SeatConfiguration> SeatConfigurations { get; set; }
    }
}