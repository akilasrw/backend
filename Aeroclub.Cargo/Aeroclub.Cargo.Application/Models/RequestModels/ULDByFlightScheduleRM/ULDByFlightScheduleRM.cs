using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.RequestModels.ULDByFlightScheduleRM
{
    public class ULDByFlightScheduleRM
    {
        public string flightNumber { get; set; }
        public DateTime scheduledDepartureDateTime { get; set; }
    }
}
