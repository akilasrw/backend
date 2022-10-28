using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.Queries.CargoAgentQMs
{
    public class CargoAgentListQM : BasePaginationQM
    {
        public CargoAgentStatus Status { get; set; }
        public string? CargoAgentName { get; set; }
        public bool IsCountryInclude { get; set; }
        public bool IsAirportInclude { get; set; }
    }
}
