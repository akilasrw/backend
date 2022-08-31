using Aeroclub.Cargo.Application.Models.Core;

namespace Aeroclub.Cargo.Application.Models.Queries.CargoAgentQMs
{
    public class CargoAgentQM : BaseQM
    {
        public Guid AppUserId { get; set; }
        public bool IsCountryInclude { get; set; }
    }
}
