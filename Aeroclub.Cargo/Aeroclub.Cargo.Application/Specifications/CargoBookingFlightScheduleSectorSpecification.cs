
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class CargoBookingFlightScheduleSectorSpecification : BaseSpecification<CargoBookingFlightScheduleSector>
    {
        public CargoBookingFlightScheduleSectorSpecification(FlightScheduleSectorBookingListQM query)
             : base(x => ((string.IsNullOrEmpty(query.FlightNumber) ||(x.FlightScheduleSector != null && x.FlightScheduleSector.FlightNumber != null && x.FlightScheduleSector.FlightNumber.Contains(query.FlightNumber))) &&
           (query.FlightDate == DateTime.MinValue || (x.FlightScheduleSector != null && x.FlightScheduleSector.ScheduledDepartureDateTime.Date == query.FlightDate.Date))) && 
             (query.StandByStatus == Common.Enums.StandByStatus.None || x.CargoBooking.StandByStatus == query.StandByStatus)
             && (!x.FlightScheduleSector.IsDeleted))
        {
            AddInclude(x => x.Include(y => y.CargoBooking).ThenInclude(x => x.PackageItems).ThenInclude(a => a.PackageULDContainers).ThenInclude(b => b.ULDContainer).ThenInclude(c => c.ULDContainerCargoPositions));
            AddInclude(x => x.Include(y => y.FlightScheduleSector));
            AddInclude(x => x.Include(y => y.CargoBooking).ThenInclude(x => x.AWBInformation));
        }

    }
}
