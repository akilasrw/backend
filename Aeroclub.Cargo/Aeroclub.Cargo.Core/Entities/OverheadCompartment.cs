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
        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }
        public Guid OverheadLayoutId { get; set; }
        public bool IsOccupied { get; set; }

        public virtual OverheadLayout OverheadLayout { get; set; }
        public virtual ICollection<OverheadPosition> Overheads { get; set; }
    }
}
