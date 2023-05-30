using Aeroclub.Cargo.Application.Models.Core;

namespace Aeroclub.Cargo.Application.Models.Queries.ULDQMs
{
    public class ULDListQM: BasePaginationQM
    {
        public string? ULDNumber { get; set; }
    }
}
