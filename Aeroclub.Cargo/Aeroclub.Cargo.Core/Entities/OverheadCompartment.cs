using Aeroclub.Cargo.Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Core.Entities
{
    public class OverheadCompartment : AuditableEntity
    {
        public int Sequence { get; set; }      // 1,2,3  in a compartment
        public bool IsOccupied { get; set; }
        public Guid ZoneAreaId { get; set; }
        public Guid OverheadCompartmentConfigurationId { get; set; }

        public virtual ZoneArea ZoneArea { get; set; }
        public virtual OverheadCompartmentConfiguration OverheadCompartmentConfigurations { get; set; }
    }
}
