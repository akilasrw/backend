using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorPalletQMs
{
    public class FlightScheduleSectorPalletQuery
    {
        public Guid FlightScheduleSectorId { get; set; }
        public Guid ULDId { get; set; }
        public bool IncludeUld { get; set; }
        public bool IncludeFlightSchedule { get; set; }
    }
}
