﻿using Aeroclub.Cargo.Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Core.Entities
{
    public class TruckInfo : AuditableEntity
    {
        public Guid truckId { get; set; }
        public Guid bookingId { get; set; }

        public int pickedUpCount { get; set; }
        public int handOverCount { get; set; }


        public virtual CargoBooking Booking { get; set; }
        public virtual Truck Truck { get; set; }
        public virtual AppUser User { get; set; }
    }
}
