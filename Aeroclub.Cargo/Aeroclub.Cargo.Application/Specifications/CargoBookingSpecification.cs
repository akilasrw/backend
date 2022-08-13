using Aeroclub.Cargo.Application.Models.Queries.CargoBookingQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
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
            (query.Destination == x.FlightScheduleSector.DestinationAirportName || query.Destination == x.FlightScheduleSector.DestinationAirportCode)) && 
            (query.BookingDate == null|| query.BookingDate == DateTime.MinValue || query.BookingDate == x.BookingDate.Date))
        {

            

            if (!isCount)
            {
                ApplyPaging(query.PageSize * (query.PageIndex - 1), query.PageSize);
                AddInclude(x => x.Include(y => y.FlightScheduleSector));
                AddInclude(x => x.Include(y => y.PackageItems));
                AddOrderByDescending(x => x.Created);
            }     
        }

        public CargoBookingSpecification(CargoBookingDetailQM query)
            :base(x => (query.UserId != Guid.Empty && query.UserId == x.CreatedBy) && (x.Id == query.Id) && (!x.IsDeleted))
        {
            if (query.IsIncludeFlightDetail)
                AddInclude(x => x.Include(y => y.FlightScheduleSector));

            if (query.IsIncludePackageDetail)
                AddInclude(x => x.Include(y => y.PackageItems).ThenInclude(y => y.AWBInformation).ThenInclude(y => y.PackageProducts));

        }

        public CargoBookingSpecification(CargoBookingCountQM query)
            : base(x => x.Created.Year == query.Year && x.Created.Month == query.Month)
        {

        }

        public CargoBookingSpecification(BookingSummaryQuery query)
            :base(x=> (query.FlightScheduleId == Guid.Empty || x.FlightScheduleSectorId == query.FlightScheduleId))
        {
            AddInclude(x => x.Include(y => y.FlightScheduleSector).ThenInclude(y => y.Aircraft));
        }

    }

}
