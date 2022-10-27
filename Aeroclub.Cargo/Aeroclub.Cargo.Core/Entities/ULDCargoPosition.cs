using Aeroclub.Cargo.Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Core.Entities
{
    public class ULDCargoPosition : BaseEntity
    {
        public Guid ULDId { get; set; }
        public Guid CargoPositionId { get; set; }

        public CargoPosition CargoPosition { get; set; }
        public ULD ULD { get; set; }
    }
}
