using Aeroclub.Cargo.Application.Models.Queries.PackageItemQMs;
using Aeroclub.Cargo.Application.Models.Queries.PackageQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class PackageItemSpecification : BaseSpecification<PackageItem>
    {
        public PackageItemSpecification(PackageItemCountQM query)
               : base(x => x.Created.Year == query.Year && x.Created.Month == query.Month)
        {
        }

        public PackageItemSpecification(PackageItemQM query)
               : base(x => query.PackageRefNumber == null || x.PackageRefNumber.ToLower() == query.PackageRefNumber.ToLower())
        {
            AddInclude(x => x.Include(y => y.VolumeUnit));
            AddInclude(x => x.Include(y => y.WeightUnit));
            AddInclude(x => x.Include(y => y.CargoBooking).ThenInclude(y => y.FlightScheduleSector));
            AddInclude(x => x.Include(y => y.ULDContainer).ThenInclude(y => y.ULDContainerCargoPositions).ThenInclude(z=>z.CargoPosition));
        }

        public PackageItemSpecification(PackageListQM query, bool isCount = false)
            :base()
        {

            if (!isCount)
            {
                ApplyPaging(query.PageSize * (query.PageIndex - 1), query.PageSize);
                AddInclude(x => x.Include(y => y.CargoBooking).ThenInclude(y=>y.FlightScheduleSector));
                
            }
        }
    }
}
