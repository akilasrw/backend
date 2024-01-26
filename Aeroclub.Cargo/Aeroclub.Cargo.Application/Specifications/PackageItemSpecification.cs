using Aeroclub.Cargo.Application.Models.Queries.PackageItemQMs;
using Aeroclub.Cargo.Application.Models.Queries.PackageQMs;
using Aeroclub.Cargo.Application.Models.RequestModels;
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


        public PackageItemSpecification(PackageItemRefQM query)
               : base(x => query.PackageRefNumber == null || x.PackageRefNumber.ToLower() == query.PackageRefNumber.ToLower())
        {
            AddInclude(x => x.Include(y => y.VolumeUnit));
            AddInclude(x => x.Include(y => y.WeightUnit));
            AddInclude(x => x.Include(y => y.CargoBooking).ThenInclude(y => y.CargoBookingFlightScheduleSectors).ThenInclude(z=>z.FlightScheduleSector));
            AddInclude(x => x.Include(y => y.PackageULDContainers).ThenInclude(z=>z.ULDContainer).ThenInclude(a => a.ULDContainerCargoPositions).ThenInclude(b=>b.CargoPosition));
        }

        public PackageItemSpecification(PackageItemByBookingQM query)
               : base(x => x.CargoBookingId == query.BookingID)
        {
            AddInclude(x => x.Include(y => y.CargoBooking));
        }

        public PackageItemSpecification(PackageListQM query, bool isCount = false)
            :base(x => query.awbNumber == null || query.awbNumber == x.CargoBooking.AWBInformation.AwbTrackingNumber)
        {

            if (!isCount)
            {
                ApplyPaging(query.PageSize * (query.PageIndex - 1), query.PageSize);
                AddInclude(x => x.Include(y => y.CargoBooking).ThenInclude(y=>y.CargoBookingFlightScheduleSectors).ThenInclude(z=>z.FlightScheduleSector));
                AddOrderByDescending(x => x.Created);
            }
        }
    }
}
