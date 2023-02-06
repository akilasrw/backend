using Aeroclub.Cargo.Application.Models.Queries.CargoBookingQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class CargoBookingSpecification : BaseSpecification<CargoBooking>
    {
        public CargoBookingSpecification(CargoBookingFilteredListQM query, bool isCount = false)
            :base(x=> (query.UserId != Guid.Empty  && query.UserId == x.CreatedBy) && (string.IsNullOrEmpty(query.BookingId) || query.BookingId == x.BookingNumber) && 
            (string.IsNullOrEmpty(query.Destination) || 
            (query.Destination == x.DestinationAirport.Name || query.Destination == x.DestinationAirport.Code)) && 
            (query.BookingDate == null|| query.BookingDate == DateTime.MinValue || query.BookingDate == x.BookingDate.Date))
        {

            

            if (!isCount)
            {
                ApplyPaging(query.PageSize * (query.PageIndex - 1), query.PageSize);
                AddInclude(x => x.Include(y => y.CargoBookingFlightScheduleSectors).ThenInclude(z=>z.FlightScheduleSector));
                AddInclude(x => x.Include(y => y.CargoBookingFlightScheduleSectors).ThenInclude(z => z.FlightScheduleSector).ThenInclude(w=>w.AircraftSubType));
                AddInclude(x => x.Include(y => y.PackageItems));
                AddOrderByDescending(x => x.Created);
            }     
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
          : base(x => (x.Id == query.Id) && (!x.IsDeleted))
        {
            if (query.IsIncludeFlightDetail)
                AddInclude(x => x.Include(y => y.CargoBookingFlightScheduleSectors).ThenInclude(z=>z.FlightScheduleSector).ThenInclude(w => w.AircraftSubType));

            if (query.IsIncludeAWBDetail)
                AddInclude(x => x.Include(y => y.AWBInformation));

            if (query.IsIncludePackageDetail)
                AddInclude(x => x.Include(y => y.PackageItems));

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

    }

}
