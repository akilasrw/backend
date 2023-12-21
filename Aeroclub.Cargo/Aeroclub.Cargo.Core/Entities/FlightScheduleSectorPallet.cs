using Aeroclub.Cargo.Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Core.Entities
{
    public class FlightScheduleSectorPallet: AuditableEntity
    {
        public Guid FlightScheduleSectorId { get; set; }
        public Guid ULDId { get; set; }

        public virtual FlightScheduleSector FlightScheduleSector { get; set; }
        public virtual ULD ULD { get; set; }
    }
}
