

using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.Queries.CargoPositionQMs
{
    public class CargoSeatPositionListQM
    {
        public Guid AircraftLayoutId { get; set; }
        public bool IncludeSeat { get; set; }
        public CargoPositionType CargoPositionType { get; set; }
    }
}
