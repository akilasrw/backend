using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.Queries.AWBNumberStackQMs
{
    public class AWBNumberStackListQM : BasePaginationQM
    {
        public bool IsAgentInclude { get; set; } = false;
        public string? CargoAgentName { get; set; } = null;
        public AWBNumberStatus AWBNumberStatus { get; set; }

    }
}
