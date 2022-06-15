using Aeroclub.Cargo.Application.Models.Core;

namespace Aeroclub.Cargo.Application.Models.Queries.AirportQMs
{
    public class AirportListQM : BasePaginationQM
    {
        public bool IsCountryInclude { get; set; } = false;
        public string? CountryName { get; set; } = null;
        public string? AirportName { get; set; } = null;
        public string? AirportCode { get; set; } = null;
    }
}
