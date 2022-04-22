using Aeroclub.Cargo.Application.Models.Queries.WarehouseQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class WarehouseSpecification : BaseSpecification<Warehouse>
    {

        public WarehouseSpecification(WarehouseQM query)
           : base(x => (x.Id == query.Id) && (!x.IsDeleted))
        {

        }
    }
}
