using Aeroclub.Cargo.Application.Models.Queries.RateQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class PackageContainerSectorSpecification : BaseSpecification<PackageContainerSector>
    {

        public PackageContainerSectorSpecification(RateSectorQM query, bool isCount = false)
            : base(x => query.SectorId == Guid.Empty ||  x.SectorId == query.SectorId )
        {

            if (!isCount)
            {
                ApplyPaging(query.PageSize * (query.PageIndex - 1), query.PageSize);
                AddInclude(y => y.Include(x => x.PackageContainer));
            }
           
            
        }



    }
}
