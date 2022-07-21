using Aeroclub.Cargo.Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Core.Entities
{
    public class OverheadLayout : AuditableEntity
    {
        public bool IsBaseLayout { get; set; } = false;
        public virtual ICollection<OverheadCompartmentConfiguration> OverheadCompartments { get; set; }

    }
}
