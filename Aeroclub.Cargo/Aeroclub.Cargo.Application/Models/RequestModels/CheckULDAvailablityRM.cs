using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.RequestModels
{
    public class CheckULDAvailablityRM
    {
        public string ULD { get; set; }
        public string FlightNum { get; set; }
        public DateTime FlightDate { get; set; }
    }
}
