using Aeroclub.Cargo.Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Core.Entities
{
    public class OverheadPosition : AuditableEntity
    {
        public int Sequence { get; set; }      // 1,2,3  row
        public bool IsOccupied { get; set; }
        public Guid ZoneAreaId { get; set; }
        public Guid OverheadCompartmentId { get; set; }

        public virtual ZoneArea ZoneArea { get; set; }
        public virtual OverheadCompartment OverheadCompartment { get; set; }
    }
}
