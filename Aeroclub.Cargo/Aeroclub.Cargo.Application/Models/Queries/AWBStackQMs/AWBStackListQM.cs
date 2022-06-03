

using Aeroclub.Cargo.Application.Models.Core;

namespace Aeroclub.Cargo.Application.Models.Queries.AWBStackQMs
{
    public class AWBStackListQM : BasePaginationQM
    {
        public bool IsAgentInclude { get; set; } = false;

    }
}
