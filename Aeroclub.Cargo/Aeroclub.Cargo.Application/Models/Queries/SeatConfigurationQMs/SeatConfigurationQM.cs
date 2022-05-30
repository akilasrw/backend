using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.Queries.SeatConfigurationQMs
{
    public class SeatConfigurationQM : BaseQM
    {
        //public Guid? SeatId { get; set; }
        public SeatConfigurationType SeatConfigurationType { get; set; }
        public bool IncludeSeats { get; set; }
        public bool IncludeZones { get; set; }
    }
}
