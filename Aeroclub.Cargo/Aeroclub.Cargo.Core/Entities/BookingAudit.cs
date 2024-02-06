using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Core.Entities
{
    public class BookingAudit : AuditableEntity
    {
        public Guid bookingId {  get; set; }

        public BookingStatus bookingStatus { get; set; }

        public CargoBooking cargoBooking { get; set; }
    }
}
