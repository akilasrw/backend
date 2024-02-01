using Aeroclub.Cargo.Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Core.Entities
{
    public class Shipment : AuditableEntity
    {
        public Guid bookingID { get; set; }
        public Guid packageID { get; set; }
        public Guid? flightScheduleID { get; set; }
        public int packageCount { get; set; }

        public CargoBooking CargoBooking { get; set; }
        public FlightSchedule FlightSchedule { get; set; }

        public PackageItem PackageItem { get; set; }



    }
}
