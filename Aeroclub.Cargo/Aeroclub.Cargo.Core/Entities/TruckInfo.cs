using Aeroclub.Cargo.Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Core.Entities
{
    public class TruckInfo : AuditableEntity
    {
        public string TruckID { get; set; }
        public Guid BookingID { get; set; }
        public virtual AppUser User { get; set; }
        public virtual CargoBooking Booking { get; set; }
    }
}
