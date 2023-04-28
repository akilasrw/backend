using Aeroclub.Cargo.Application.Models.Queries.CargoBookingSummaryQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleManagementQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class FlightScheduleSpecification : BaseSpecification<FlightSchedule>
    {
        public FlightScheduleSpecification(FlightScheduleListQM query, bool isCount = false)
        : base(x=> 
            (query.FlightDate == DateTime.MinValue || x.ScheduledDepartureDateTime.Date == query.FlightDate.Date) &&
            (query.OriginAirportId == Guid.Empty || x.OriginAirportId == query.OriginAirportId) &&
            (query.DestinationAirportId == Guid.Empty || x.DestinationAirportId == query.DestinationAirportId)
        )
        {
            if (!isCount)
            {
                if (query.IncludeFlightScheduleSectors)
                    AddInclude(x => x.Include(y => y.FlightScheduleSectors));


                if (query.IncludeAircraftSubType)
                    AddInclude(x => x.Include(y => y.AircraftSubType));
            }

        } 
        
        public FlightScheduleSpecification(FlightScheduleStandbyQM query)
        : base(x=> 
            (query.FlightDate == DateTime.MinValue || x.ScheduledDepartureDateTime.Date == query.FlightDate.Date) &&
            (string.IsNullOrEmpty(query.FlightNumber) || x.FlightNumber.Contains(query.FlightNumber))
        )
        {
                if (query.IncludeFlightScheduleSectors)
                    AddInclude(x => x.Include(y => y.FlightScheduleSectors));           

        }

        public FlightScheduleSpecification(FlightScheduleQM query)
            : base(x => (query.Id == Guid.Empty || x.Id == query.Id) &&
            (query.FlightId == Guid.Empty || x.FlightId == query.FlightId))
        {

            if (query.IncludeFlightScheduleSectors)
                AddInclude(x => x.Include(y => y.FlightScheduleSectors));

        }

        public FlightScheduleSpecification(CargoBookingSummaryFilteredListQM query, bool isCount = false)
           : base(x => (string.IsNullOrEmpty(query.FlightNumber) || x.FlightNumber.Contains(query.FlightNumber)) &&
           (query.FlightDate == null || query.FlightDate == DateTime.MinValue || query.FlightDate == x.ScheduledDepartureDateTime.Date))
        {

            if (!isCount)
            {
                ApplyPaging(query.PageSize * (query.PageIndex - 1), query.PageSize);
                AddInclude(x => x.Include(y => y.AircraftSubType).ThenInclude(z => z.AircraftType));
                AddOrderByDescending(x => x.Created);
            }
        }

        public FlightScheduleSpecification(CargoBookingSummaryDetailQM query)
            : base(x => (query.Id == Guid.Empty || x.Id == query.Id))
        {
            if (query.IsIncludeAircraftType)
            {
                AddInclude(x => x.Include(y => y.AircraftSubType).ThenInclude(z => z.AircraftType));
            }

            if (query.IsIncludeFlightScheduleSectors)
            {
                AddInclude(x => x.Include(y => y.FlightScheduleSectors).ThenInclude(f=>f.Flight).ThenInclude(p=> p.FlightSectors));
                AddInclude(x => x.Include(y => y.FlightScheduleSectors).ThenInclude(z => z.CargoBookingFlightScheduleSectors).ThenInclude(p=>p.CargoBooking));
            }
        }

        public FlightScheduleSpecification(FlightScheduleLinkQM query)
            : base(x => (query.FlightScheduleManagementId == null || query.FlightScheduleManagementId == x.FlightScheduleManagementId) && 
                (query.FlightScheduleId == null || x.Id == query.FlightScheduleId))
        {
            if (query.IncludeFlightScheduleSectors)
                AddInclude(c => c.Include(v => v.FlightScheduleSectors).ThenInclude(b => b.Flight.FlightSectors));

            if (query.IncludeAircrafts)
            {
                AddInclude(x => x.Include(y => y.Aircraft));
                AddInclude(x => x.Include(y => y.AircraftSubType.AircraftType));
            }               
        }

        public FlightScheduleSpecification(Guid aircraftScheduleId)
            : base(x=> x.AircraftScheduleId == aircraftScheduleId)
        {
            AddInclude(x => x.Include(y => y.FlightScheduleSectors).ThenInclude(f => f.Flight).ThenInclude(p => p.FlightSectors));
            AddInclude(x => x.Include(y => y.Aircraft));
            AddInclude(x => x.Include(y => y.AircraftSchedule));
        }

        public FlightScheduleSpecification(FlightScheduleReportQM query)
            : base(x=> query.StartDate == null || (x.ScheduledDepartureDateTime.Date >= new DateTime(query.StartDate.Value.Year, query.StartDate.Value.Month,1).Date) &&
                 query.EndDate == null || (x.ScheduledDepartureDateTime.Date <= new DateTime(query.EndDate.Value.Year, query.EndDate.Value.Month, DateTime.DaysInMonth(query.EndDate.Value.Year, query.EndDate.Value.Month)).Date) &&
                ((query.Month == null && query.Year == null) || (x.ScheduledDepartureDateTime.Year == query.Year && x.ScheduledDepartureDateTime.Date.Month == query.Month)) && 
            x.AircraftId.HasValue)
        {                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
            AddInclude(x => x.Include(y => y.FlightScheduleSectors).ThenInclude(f => f.Flight).ThenInclude(p => p.FlightSectors));
            AddInclude(x => x.Include(y => y.Aircraft));
            AddInclude(x => x.Include(y => y.AircraftSchedule));
        }

        public FlightScheduleSpecification(FlightScheduleManagemenLinktFilteredListQM query, bool isCount = false)
            : base(x => (string.IsNullOrEmpty(query.FlightNumber) || x.FlightNumber.Contains(query.FlightNumber)) &&
           (query.FlightDate == null || query.FlightDate == DateTime.MinValue || query.FlightDate == x.ScheduledDepartureDateTime.Date) &&
            (query.DestinationAirportId == Guid.Empty || x.DestinationAirportId == query.DestinationAirportId) &&
            (query.OriginAirportId == Guid.Empty || x.OriginAirportId == query.OriginAirportId) &&
            (query.IsHistory == null || (query.IsHistory == false ? x.ActualDepartureDateTime == DateTime.MinValue : x.ActualDepartureDateTime != DateTime.MinValue)))
        {
            if (!isCount)
            {
                AddInclude(c => c.Include(v => v.FlightScheduleSectors).ThenInclude(b => b.Flight.FlightSectors));
                AddInclude(x => x.Include(y => y.FlightScheduleSectors).ThenInclude(z => z.CargoBookingFlightScheduleSectors));
                AddInclude(x => x.Include(y => y.AircraftSubType.AircraftType));
                ApplyPaging(query.PageSize * (query.PageIndex - 1), query.PageSize);
                AddOrderByDescending(x => x.ScheduledDepartureDateTime);
            }
        }

    }
}