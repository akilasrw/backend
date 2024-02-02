using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.Queries.ShipmentQM
{
    public class ShipmentQM
    {
        public Guid bookingID { get; set; }
        public Guid userId { get; set; }
        public Guid flightScheduleID { get; set; }
    }
}
