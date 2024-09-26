using Aeroclub.Cargo.Application.Models.Queries;
using Aeroclub.Cargo.Application.Models.Queries.ItemsByDateQM;
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

        public PackageItemSpecification(GetPackageByAWBAndRefQM query)
              : base(x => x.PackageRefNumber == query.packageNum && x.CargoBooking.AWBInformation.AwbTrackingNumber == query.awb)
        {
        }

        public PackageItemSpecification(string refNum, long awb)
               : base(x => x.PackageRefNumber == refNum && x.CargoBooking.AWBInformation.AwbTrackingNumber == awb)
        {
        }


        public PackageItemSpecification(CheckPackageAvailabilityRM rm)
              : base(x => x.PackageRefNumber == rm.PackageRef && x.CargoBooking.AWBInformation.AwbTrackingNumber == rm.AwbNumber && (x.PackageItemStatus == Common.Enums.PackageItemStatus.Offloaded || x.PackageItemStatus == Common.Enums.PackageItemStatus.Returned || x.PackageItemStatus == Common.Enums.PackageItemStatus.AcceptedForFLight || x.PackageItemStatus == Common.Enums.PackageItemStatus.PickedUp || x.PackageItemStatus == Common.Enums.PackageItemStatus.Booking_Made || x.PackageItemStatus == Common.Enums.PackageItemStatus.Cargo_Received))
        {
        }

        public PackageItemSpecification(PackageListByAwbAndStatus query)
               : base(x => x.CargoBooking.AWBInformation.AwbTrackingNumber == query.AwbNumber && query.packageItemStatuses.Contains(x.PackageItemStatus))
        {
        }


        public PackageItemSpecification(PackageItemRefQM query)
               : base(x => (query.PackageRefNumber == null || x.PackageRefNumber.ToLower() == query.PackageRefNumber.ToLower()) && (query.AwbNumber == null || query.AwbNumber == x.CargoBooking.AWBInformation.AwbTrackingNumber))
        {
            AddInclude(x => x.Include(y => y.VolumeUnit));
            AddInclude(x => x.Include(y => y.WeightUnit));
            AddInclude(x => x.Include(y => y.CargoBooking).ThenInclude(y => y.CargoBookingFlightScheduleSectors).ThenInclude(z=>z.FlightScheduleSector));
            AddInclude(x => x.Include(y => y.PackageULDContainers).ThenInclude(z=>z.ULDContainer).ThenInclude(a => a.ULDContainerCargoPositions).ThenInclude(b=>b.CargoPosition));
        }
        public PackageItemSpecification(PackageItemWithAWBQM query)
            : base(x => (query.PackageRefNumber == null || (x.PackageRefNumber.ToLower() == query.PackageRefNumber.ToLower() && query.AwbNumber == x.CargoBooking.AWBInformation.AwbTrackingNumber)) && (query.AwbNumber == null || query.AwbNumber == x.CargoBooking.AWBInformation.AwbTrackingNumber))
        {
            AddInclude(x => x.Include(y => y.VolumeUnit));
            AddInclude(x => x.Include(y => y.WeightUnit));
            AddInclude(x => x.Include(y => y.Shipment).ThenInclude(y => y.CargoBooking).ThenInclude((x) => x.AWBInformation));
            AddInclude(x => x.Include(y => y.Shipment).ThenInclude(y => y.FlightSchedule));
            AddInclude(x => x.Include(y => y.CargoBooking).ThenInclude(y => y.CargoBookingFlightScheduleSectors).ThenInclude(z=>z.FlightScheduleSector));
            AddInclude(x => x.Include(y => y.PackageULDContainers).ThenInclude(z=>z.ULDContainer).ThenInclude(a => a.ULDContainerCargoPositions).ThenInclude(b=>b.CargoPosition));
        }

        public PackageItemSpecification(PackageItemByBookingQM query)
               : base(x => x.CargoBookingId == query.BookingID && (query.PackageItemStatus == null || x.PackageItemStatus == query.PackageItemStatus))
        {
            AddInclude(x => x.Include(y => y.CargoBooking));
        }

        public PackageItemSpecification(DateTime date)
            : base(x =>  (date == null) || (x.Created.Date == date))
        {

        }

        public PackageItemSpecification(ItemsByDateQM query)
            : base(x =>  (x.Created.Date >= query.start && x.Created.Date <= query.end))
        {
            AddInclude(x => x.Include(y => y.Shipment).ThenInclude(x => x.FlightSchedule));
            AddInclude(x => x.Include(y => y.CargoBooking).ThenInclude(x => x.AWBInformation));
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

        public PackageItemSpecification(PackageAllListQM query)
             :base(x => query.awbNumber == null || query.awbNumber == x.CargoBooking.AWBInformation.AwbTrackingNumber) 
        { }
            
    }
}
