using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingQMs;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class CargoBookingSpecification : BaseSpecification<CargoBooking>
    {
        public CargoBookingSpecification(CargoBookingFilteredListQM query, bool isCount = false)
            :base(x=> (query.UserId == null || (query.UserId != null  && query.UserId == x.CreatedBy)) && (string.IsNullOrEmpty(query.BookingId) ||query.BookingId == x.BookingNumber) && 
                      (string.IsNullOrEmpty(query.AwbNumber) || query.AwbNumber == x.AWBInformation.AwbTrackingNumber.ToString()) && 
            (string.IsNullOrEmpty(query.Destination) || 
            (query.Destination == x.DestinationAirport.Name || query.Destination == x.DestinationAirport.Code)) &&
            ((query.FromDate == null || query.FromDate == DateTime.MinValue) || x.BookingDate.Date >= query.FromDate.Value) &&
            ((query.ToDate == null || query.ToDate == DateTime.MinValue) || x.BookingDate.Date <= query.ToDate.Value))
        {

            //AddInclude(x => x.Include(y => y.PackageItems));

            if (!isCount)
            {
                ApplyPaging(query.PageSize * (query.PageIndex - 1), query.PageSize);
                AddInclude(x => x.Include(y => y.AWBInformation));
                AddInclude(x => x.Include(y => y.DestinationAirport));
                AddInclude(x => x.Include(y => y.CargoBookingFlightScheduleSectors).ThenInclude(z=>z.FlightScheduleSector));
                AddInclude(x => x.Include(y => y.CargoBookingFlightScheduleSectors).ThenInclude(z => z.FlightScheduleSector).ThenInclude(w=>w.AircraftSubType));
                //AddInclude(x => x.Include(y => y.PackageItems));
                AddOrderByDescending(x => x.Created);
            }     
        }

        public CargoBookingSpecification(IEnumerable<Guid> flightScheduleSectorIds)
    : base(x => x.CargoBookingFlightScheduleSectors.Any(cbs => flightScheduleSectorIds.Contains(cbs.FlightScheduleSectorId)))
        {
            // Include statements for related entities
            AddInclude(x => x.Include(y => y.DestinationAirport));
            AddInclude(x => x.Include(y => y.CargoBookingFlightScheduleSectors).ThenInclude(z => z.FlightScheduleSector));
            AddInclude(x => x.Include(y => y.CargoBookingFlightScheduleSectors).ThenInclude(z => z.FlightScheduleSector).ThenInclude(w => w.AircraftSubType));
            AddInclude(x => x.Include(y => y.PackageItems));
            AddOrderByDescending(x => x.Created);
        }

        public CargoBookingSpecification(CargoBookingDetailQM query)
            :base(x => (query.UserId != Guid.Empty && query.UserId == x.CreatedBy) && (x.Id == query.Id) && (!x.IsDeleted))
        {
            if (query.IsIncludeFlightDetail)
                AddInclude(x => x.Include(y => y.CargoBookingFlightScheduleSectors).ThenInclude(z => z.FlightScheduleSector).ThenInclude(a=>a.FlightSchedule));

            if (query.IsIncludeAWBDetail)
                AddInclude(x => x.Include(y=>y.AWBInformation));

            if (query.IsIncludePackageDetail)
                AddInclude(x => x.Include(y => y.PackageItems));

        }

        public CargoBookingSpecification(CargoBookingQM query)
          : base(x => (query.userId == Guid.Empty || x.CreatedBy == query.userId) && (x.Id == query.Id) && (!x.IsDeleted))
        {
            AddInclude((x) => x.Include((x) => x.AWBInformation));
            if (query.IsIncludeFlightDetail)
            {
                AddInclude(x => x.Include(y => y.CargoBookingFlightScheduleSectors).ThenInclude(z => z.FlightScheduleSector).ThenInclude(w => w.AircraftSubType));
                AddInclude(x => x.Include(y => y.CargoBookingFlightScheduleSectors).ThenInclude(z => z.FlightScheduleSector).ThenInclude(w => w.FlightSchedule));

            }                

            if (query.IsIncludeAWBDetail)
                AddInclude(x => x.Include(y => y.AWBInformation));

            if (query.IsIncludePackageDetail)
                AddInclude(x => x.Include(y => y.PackageItems).ThenInclude(z=>z.PackageULDContainers));

        }

        

        //public CargoBookingSpecification(CargoBookingListQM query)
        //    : base(x => ((string.IsNullOrEmpty(query.FlightNumber) || x.FlightScheduleSector.FlightNumber.Contains(query.FlightNumber)) && 
        //    (query.FlightDate == DateTime.MinValue || x.FlightScheduleSector.ScheduledDepartureDateTime.Date == query.FlightDate.Date)) && (!x.IsDeleted))
        //{
        //        AddInclude(x => x.Include(y => y.FlightScheduleSector));
        //        AddInclude(x => x.Include(y => y.PackageItems));

        //}

        public CargoBookingSpecification(CargoBookingCountQM query)
            : base(x => x.Created.Year == query.Year && x.Created.Month == query.Month)
        {

        }

        public CargoBookingSpecification(PackageItemStatus type, StandbyCargoBookingsQM query, bool isCount)
            : base(y => (query.CargoAgent == Guid.Empty || 
            (query.CargoAgent == y.CreatedBy)) && (query.CargoBooking == null || 
            (query.CargoBooking == y.BookingNumber)) && 
            (
            (type == PackageItemStatus.Offloaded && y.PackageItems.Any((x) => x.PackageItemStatus == Common.Enums.PackageItemStatus.Offloaded)) || 
            (type == PackageItemStatus.PickedUp && (y.PackageItems.Any((x) => x.PackageItemStatus == Common.Enums.PackageItemStatus.PickedUp) || y.PackageItems.Any((x) => x.PackageItemStatus == Common.Enums.PackageItemStatus.Booking_Made))))
            )
        {
            if (!isCount)
            {
                ApplyPaging(query.PageSize * (query.PageIndex - 1), query.PageSize);
                AddInclude(x => x.Include((y) => y.AWBInformation));
                AddInclude(x => x.Include((y) => y.PackageItems));
                AddInclude(x => x.Include(y => y.OriginAirport));
                AddInclude(x => x.Include(y => y.DestinationAirport));
            }

        }

    }

}
