using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs
{
    public class FlightScheduleSectorSearchQM
    {
        public string FlightNumber { get; set; }
        public Guid AircraftId { get; set; }
        public DateTime FlightDate { get; set; } = DateTime.MinValue;
    }
}
