using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.ViewModels.SectorVMs;

namespace Aeroclub.Cargo.Application.Models.ViewModels.FlightSectorVMs
{
    public class FlightSectorVM : BaseVM
    {
        public Guid FlightId { get; set; }
        public Guid SectorId { get; set; }
        public int Sequence { get; set; }
        public DateTime DepartureDateTime { get; set; }
        public DateTime ArrivalDateTime { get; set; }
        public double OriginBlockTimeMin { get; set; }
        public double DestinationBlockTimeMin { get; set; }

        public SectorVM? Sector { get; set; }

    }
}
