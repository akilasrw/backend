using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.Dtos
{
    public class AircraftDto: BaseDto
    {
        public string RegNo { get; set; } = null!;
        public AircraftTypes AircraftType { get; set; }
        public AircraftSubTypes AircraftSubType { get; set; }
        public AircraftConfigType ConfigurationType { get; set; }
        public AircraftStatus Status { get; set; }
        public Guid? AircraftScheduleId { get; set; }
    }
}
