using Aeroclub.Cargo.Application.Models.Queries.CargoBookingSummaryQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class FlightScheduleSpecification : BaseSpecification<FlightSchedule>
    {
        public FlightScheduleSpecification(FlightScheduleListQM query)
        : base(x=> 
            (query.FlightDate == DateTime.MinValue || x.ScheduledDepartureDateTime.Date == query.FlightDate.Date) &&
            (query.OriginAirportId == Guid.Empty || x.OriginAirportId == query.OriginAirportId) &&
            (query.DestinationAirportId == Guid.Empty || x.DestinationAirportId == query.DestinationAirportId)
        )
        {
            
        }

        public FlightScheduleSpecification(FlightScheduleQM query)
            : base(x => (query.Id == Guid.Empty || x.Id == query.Id) &&
            (query.FlightId == Guid.Empty || x.FlightId == query.FlightId))
        {

        }

        public FlightScheduleSpecification(CargoBookingSummaryFilteredListQM query, bool isCount = false)
           : base(x => (string.IsNullOrEmpty(query.FlightNumber) || x.FlightNumber.Contains(query.FlightNumber)) &&
           (query.FlightDate == null || query.FlightDate == DateTime.MinValue || query.FlightDate == x.ScheduledDepartureDateTime.Date))
        {

            if (!isCount)
            {
                ApplyPaging(query.PageSize * (query.PageIndex - 1), query.PageSize);
                AddInclude(x => x.Include(y => y.AircraftSubType));
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
                AddInclude(x => x.Include(y => y.FlightScheduleSectors));
            }
        }

        public FlightScheduleSpecification(FlightScheduleLinkQM query)
            : base(x => (query.FlightScheduleManagementId == x.FlightScheduleManagementId))
        {
            if (query.IncludeFlightScheduleSectors)
                AddInclude(x => x.Include(y => y.FlightScheduleSectors));

            if (query.IncludeAircrafts)
                AddInclude(x => x.Include(y => y.Aircraft));

        }

        public FlightScheduleSpecification(DateTime startDate, DateTime endDate)
            : base(x=> x.ActualDepartureDateTime >= startDate && x.ActualDepartureDateTime <= endDate)
        {
                AddInclude(x => x.Include(y => y.FlightScheduleSectors));
                AddInclude(x => x.Include(y => y.Aircraft));
        }

    }
}