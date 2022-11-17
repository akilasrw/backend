using Aeroclub.Cargo.Application.Models.Core;

namespace Aeroclub.Cargo.Application.Models.Dtos
{
    public class FlightSectorDto : BaseDto
    {
        public Guid FlightId { get; set; }
        public Guid SectorId { get; set; }
        public int Sequence { get; set; }
        public string DepartureDateDisplayTime { get; set; }
        public string ArrivalDateDisplayTime { get; set; }
        public double OriginBlockTimeHrs { get; set; }
        public double DestinationBlockTimeHrs { get; set; }
    }
}
