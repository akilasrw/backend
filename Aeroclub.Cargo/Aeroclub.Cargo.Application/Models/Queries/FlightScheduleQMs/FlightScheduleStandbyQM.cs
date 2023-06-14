using Aeroclub.Cargo.Application.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.Queries.FlightScheduleQMs
{
    public class FlightScheduleStandbyQM: BaseQM
    {
        public string FlightNumber { get; set; }
        public DateTime FlightDate { get; set; }
        public bool IncludeFlightScheduleSectors { get; set; }
    }
}
