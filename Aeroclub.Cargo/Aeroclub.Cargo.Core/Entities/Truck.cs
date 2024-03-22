using Aeroclub.Cargo.Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Core.Entities
{
    public class Truck : AuditableEntity
    {
        public string truckNumber { get; set; }
        public int pickedUpCount { get; set; }
        public int handOverCount { get; set; }
        public Guid bookingId { get; set; }

        public virtual CargoBooking CargoBooking { get; set; }
    }
}
