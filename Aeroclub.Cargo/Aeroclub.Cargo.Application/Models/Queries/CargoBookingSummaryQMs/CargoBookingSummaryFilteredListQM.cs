using Aeroclub.Cargo.Application.Models.Core;

namespace Aeroclub.Cargo.Application.Models.Queries.CargoBookingSummaryQMs
{
    public class CargoBookingSummaryFilteredListQM : BasePaginationQM
    {
        public string? FlightNumber { get; set; }

        public DateTime? FlightDate { get; set; }

    }
}
