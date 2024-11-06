using Aeroclub.Cargo.Core.Entities;
using EllipticCurve.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.Queries
{
    public class FlightScheduleUpdateQM
    {
        public DateTime scheduledDepartureDateTime {  get; set; }
        public DateTime scheduledArrivalDateTime { get;  set; }
        public DateTime actualDepartureDateTime { get; set; }   
        public DateTime actualArrivalDateTime { get; set; }
    }
}
