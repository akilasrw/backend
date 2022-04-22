using System;

namespace Aeroclub.Cargo.Application.Models.Queries.CargoPositionQMs
{
    public class CargoPositionListQM
    {
        public Guid AircraftLayoutId { get; set; }

        public bool IncludeSeat { get; set; }
    }
}