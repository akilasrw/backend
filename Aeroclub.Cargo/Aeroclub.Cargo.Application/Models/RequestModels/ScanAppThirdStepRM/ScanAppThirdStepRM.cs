using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.RequestModels.ScanAppThirdStepRM
{
    public class ScanAppThirdStepRM
    {
        public Guid FlightID { get; set; }
        public DateTime ScheduledDepartureDateTime { get; set; }
        public string ULDSerialNumber { get; set; }
        public string[] packageIDs { get; set; }
    }
}
