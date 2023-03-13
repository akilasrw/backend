using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Core;
using System.Text.Json.Serialization;

namespace Aeroclub.Cargo.Application.Models.Queries.FlightScheduleManagementQMs
{
    public class FlightScheduleManagementFilteredListQM : BasePaginationQM
    {
        public Guid OriginAirportId { get; set; }
        public Guid DestinationAirportId { get; set; }
        public string? FlightNumber { get; set; }

    }
    
    public class FlightScheduleManagemenLinktFilteredListQM : BasePaginationQM
    {
        public Guid OriginAirportId { get; set; }
        public Guid DestinationAirportId { get; set; }
        public string? FlightNumber { get; set; }
        public DateTime? FlightDate { get; set; }
        public bool? IsHistory { get; set; }

    }
}
