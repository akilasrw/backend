

using Aeroclub.Cargo.Application.Models.Core;

namespace Aeroclub.Cargo.Application.Models.Queries.PackageQMs
{
    public class PackageListQM : BasePaginationQM
    {
        public bool IncludeCargoBooking {get;set;}

        public long? awbNumber { get;set;}

    }
}
