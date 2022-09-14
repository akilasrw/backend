using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.ViewModels.SectorVMs;

namespace Aeroclub.Cargo.Application.Models.ViewModels.FlightSectorVMs
{
    public class FlightSectorVM : BaseVM
    {
        public Guid FlightId { get; set; }
        public Guid SectorId { get; set; }
        public int Sequence { get; set; }
        public TimeSpan? DepartureDateTime { get; set; }
        public TimeSpan? ArrivalDateTime { get; set; }

        public SectorVM? Sector { get; set; }

    }
}
