using Aeroclub.Cargo.Application.Models.Core;

namespace Aeroclub.Cargo.Application.Models.Queries.AWBNumberStackQMs
{
    public class AvailableAWBNumberStackQM
    {
        public Guid CargoAgentId { get; set; }
        public bool IsAgentInclude { get; set; }
    }
}
