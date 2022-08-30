using Aeroclub.Cargo.Application.Models.Queries.AirWayBillQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class AWBSpecification: BaseSpecification<AWBInformation>
    {
        public AWBSpecification(AirWayBillQM query)
            : base(x => (query.Id == Guid.Empty || x.Id == query.Id))
        {

        }
    }
}
