using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.Queries.SeatConfigurationQMs
{
    public class SeatConfigurationListQM
    {
        public Guid SeatLayoutId { get; set; }
        public SeatConfigurationType SeatConfigurationType { get; set; }
        public bool IncludeSeats { get; set; }
        public bool IncludeZones { get; set; }
    }
}
