using Aeroclub.Cargo.Application.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.Dtos
{
    public class OverheadCompartmentDto: BaseDto
    {
        public int Sequence { get; set; }      // 1,2,3  in a compartment
        public bool IsOccupied { get; set; }
        public Guid ZoneAreaId { get; set; }
        public Guid OverheadCompartmentConfigurationId { get; set; }
    }
}
