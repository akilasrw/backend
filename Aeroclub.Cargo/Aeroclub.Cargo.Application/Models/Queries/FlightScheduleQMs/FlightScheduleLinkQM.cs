using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.Queries.FlightScheduleQMs
{
    public class FlightScheduleLinkQM
    {
        public Guid? FlightScheduleId { get; set; }
        public Guid? FlightScheduleManagementId { get; set; }
        public bool IncludeFlightScheduleSectors { get; set; } = false;
        public bool IncludeAircrafts { get; set; } = false;
    }
}
