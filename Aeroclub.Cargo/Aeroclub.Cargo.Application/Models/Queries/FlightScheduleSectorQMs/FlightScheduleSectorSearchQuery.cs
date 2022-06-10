using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs
{
    public class FlightScheduleSectorSearchQuery
    {
        public string FlightNumber { get; set; }
        public DateTime FlightDate { get; set; } = DateTime.MinValue;
    }
}
