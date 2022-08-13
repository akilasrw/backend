using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs
{
    public class FlightScheduleSectorSearchQuery: BaseQM
    {
        public CargoPositionType CargoPositionType { get; set; } = CargoPositionType.None;

        public Guid FlightScheduleId { get; set; }
    }
}
