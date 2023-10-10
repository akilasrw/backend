
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleSectorVMs;
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
             (query.StandByStatus == Common.Enums.StandByStatus.None || x.CargoBooking.StandByStatus == query.StandByStatus) &&
             (string.IsNullOrEmpty(query.BookingNumber) || x.CargoBooking.BookingNumber.Contains(query.BookingNumber))
             && (query.FlightScheduleSectorId == null || x.FlightScheduleSector.Id == query.FlightScheduleSectorId) &&
            (!x.FlightScheduleSector.IsDeleted))
        {
            AddInclude(x => x.Include(y => y.CargoBooking).ThenInclude(x => x.PackageItems).ThenInclude(a => a.PackageULDContainers).ThenInclude(b => b.ULDContainer).ThenInclude(c => c.ULDContainerCargoPositions));
            AddInclude(x => x.Include(y => y.FlightScheduleSector));
            AddInclude(x => x.Include(y => y.CargoBooking).ThenInclude(x => x.AWBInformation));
        }

       


        public CargoBookingFlightScheduleSectorSpecification(Guid bookingId)
            : base(x=> x.CargoBookingId == bookingId)
        {
            AddInclude(x => x.Include(y => y.CargoBooking).ThenInclude(x => x.PackageItems).ThenInclude(a => a.PackageULDContainers).ThenInclude(b => b.ULDContainer).ThenInclude(c => c.ULDContainerCargoPositions));
            AddInclude(x => x.Include(y => y.FlightScheduleSector));
            AddInclude(x => x.Include(y => y.CargoBooking).ThenInclude(x => x.AWBInformation));
        }

        




        public CargoBookingFlightScheduleSectorSpecification(FlightScheduleSectorVerifyBookingListQM query)
            : base(x => query.FlightScheduleId == Guid.Empty || (x.FlightScheduleSector != null && x.FlightScheduleSector.FlightScheduleId == query.FlightScheduleId))
        {
            AddInclude(x => x.Include(y => y.CargoBooking).ThenInclude(x => x.PackageItems).ThenInclude(a => a.PackageULDContainers).ThenInclude(b => b.ULDContainer).ThenInclude(c => c.ULDContainerCargoPositions));
            AddInclude(x => x.Include(y => y.FlightScheduleSector).ThenInclude(x=>x.FlightSchedule));
            AddInclude(x => x.Include(y => y.CargoBooking).ThenInclude(x => x.AWBInformation));
        }
        
        public CargoBookingFlightScheduleSectorSpecification(FlightScheduleSectorMobileQM query)
            : base(x => query.AWBTrackingNumber == null || (x.CargoBooking != null && x.CargoBooking.AWBInformation != null && x.CargoBooking.AWBInformation.AwbTrackingNumber == query.AWBTrackingNumber) && 
            (!x.FlightScheduleSector.IsDeleted))
        {
            AddInclude(x => x.Include(y => y.CargoBooking).ThenInclude(x => x.PackageItems).ThenInclude(a => a.PackageULDContainers).ThenInclude(b => b.ULDContainer).ThenInclude(c => c.ULDContainerCargoPositions));
            AddInclude(x => x.Include(y => y.CargoBooking).ThenInclude(x => x.PackageItems).ThenInclude(a => a.VolumeUnit));
            AddInclude(x => x.Include(y => y.FlightScheduleSector).ThenInclude(x => x.FlightSchedule));
            AddInclude(x => x.Include(y => y.FlightScheduleSector).ThenInclude(v => v.AircraftSubType).ThenInclude(g=> g.AircraftType));
            AddInclude(x => x.Include(y => y.CargoBooking).ThenInclude(x => x.AWBInformation));
        }

    }
}
