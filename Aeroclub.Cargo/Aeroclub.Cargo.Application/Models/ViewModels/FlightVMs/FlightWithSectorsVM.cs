using Aeroclub.Cargo.Application.Models.ViewModels.LocationsByAWBVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.ViewModels.FlightVMs
{
    public class FlightWithSectorsVM : SectorsList
    {
        public Guid flightId {  get; set; }
        public string flightNumber { get; set;}

        

        public List<SectorsList> sectors {  get; set; } 
    }
}
