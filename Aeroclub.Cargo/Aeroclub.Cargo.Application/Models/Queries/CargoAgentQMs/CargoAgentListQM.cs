using Aeroclub.Cargo.Application.Models.Core;

namespace Aeroclub.Cargo.Application.Models.Queries.CargoAgentQMs
{
    public class CargoAgentListQM : BasePaginationQM
    {
        public string? CargoAgentName { get; set; }
        public bool IsCountryInclude { get; set; }
        public bool IsAirportInclude { get; set; }
    }
}
