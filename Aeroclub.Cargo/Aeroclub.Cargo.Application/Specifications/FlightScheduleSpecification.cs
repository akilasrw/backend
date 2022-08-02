using System;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingSummaryQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;

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
            : base(x => (query.Id == Guid.Empty || x.Id == query.Id))
        {

        }

        public FlightScheduleSpecification(CargoBookingSummaryFilteredListQM query, bool isCount = false)
           : base(x => (string.IsNullOrEmpty(query.FlightNumber) || x.FlightNumber.Contains(query.FlightNumber)) &&
           (query.FlightDate == null || query.FlightDate == DateTime.MinValue || query.FlightDate == x.ScheduledDepartureDateTime.Date))
        {

            if (!isCount)
            {
                ApplyPaging(query.PageSize * (query.PageIndex - 1), query.PageSize);
                AddInclude(x => x.Include(y => y.Aircraft));
                AddOrderByDescending(x => x.Created);
            }
        }

        public FlightScheduleSpecification(CargoBookingSummaryDetailQM query, bool isCount = false)
            : base(x => (query.Id == Guid.Empty || x.Id == query.Id))
        {
            if (query.IsIncludeAircraft)
            {
                AddInclude(x => x.Include(y => y.Aircraft));
            }
        }

    }
}