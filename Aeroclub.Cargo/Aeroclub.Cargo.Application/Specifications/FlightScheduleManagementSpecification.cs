﻿using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleManagementQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class FlightScheduleManagementSpecification : BaseSpecification<FlightScheduleManagement>
    {

        public FlightScheduleManagementSpecification(FlightScheduleManagementFilteredListQM query, bool isCount = false)
        : base(x =>((query.OriginAirportId == Guid.Empty || (x.Flight != null && x.Flight.OriginAirportId == query.OriginAirportId)) &&
       (query.DestinationAirportId == Guid.Empty || (x.Flight != null && x.Flight.DestinationAirportId == query.DestinationAirportId)) &&
        (string.IsNullOrEmpty(query.FlightNumber) || (x.Flight != null && x.Flight.FlightNumber.Contains(query.FlightNumber))))&& x.IsDeleted == false)
        {

            if (!isCount)
            {
                AddInclude(x => x.Include(y => y.FlightSchedules));
                AddInclude(x => x.Include(y => y.Flight).ThenInclude(z => z.FlightSectors));
                AddInclude(x => x.Include(y => y.Flight).ThenInclude(z => z.DestinationAirport));
                AddInclude(x => x.Include(y => y.Flight).ThenInclude(z => z.OriginAirport));
                AddInclude(x => x.Include(y => y.AircraftSubType));
                ApplyPaging(query.PageSize * (query.PageIndex - 1), query.PageSize);
                AddOrderByDescending(x => x.Created);
            }

        }

        public FlightScheduleManagementSpecification(FlightScheduleManagementDetailQM query)
            : base(x => x.Id == query.Id && !x.IsDeleted)
        {
            AddInclude(x => x.Include(y => y.Flight).ThenInclude(z => z.FlightSectors));
            AddInclude(x => x.Include(y => y.FlightSchedules).ThenInclude(z => z.FlightScheduleSectors).ThenInclude((r)=> r.Sector));
            AddInclude(x => x.Include(y => y.AircraftSubType));
            AddInclude(x => x.Include(y => y.FlightSchedules));

        }

        public FlightScheduleManagementSpecification(DateTime start, DateTime end, Guid flightID)
         : base(x => x.FlightId == flightID && x.ScheduleStartDate.Date == start.Date && x.ScheduleEndDate.Date == end.Date && x.IsDeleted ==false ) {

        }

        public FlightScheduleManagementSpecification(FlightScheduleManagemenLinktFilteredListQM query, bool isCount = false)
            : base(x => (string.IsNullOrEmpty(query.FlightNumber) || (x.Flight != null && x.Flight.FlightNumber.Contains(query.FlightNumber))))
        {
            //if (query.Status == Enums.AircaftAssignedStatus.PartiallyCompleted)
            //{
            //    And(c => c.FlightSchedules.Count() > 0 && c.FlightSchedules.Count() > c.FlightSchedules.Where(x => x.AircraftId != null).Count() && c.FlightSchedules.Where(x => x.AircraftId != null).Count() > 0);
            //}
            //else if (query.Status == Enums.AircaftAssignedStatus.Completed)
            //{
            //    And(s => s.FlightSchedules.Count() > 0 && s.FlightSchedules.Where(x => x.AircraftId != null).Count() == s.FlightSchedules.Count());
            //}
            //else if (query.Status == Enums.AircaftAssignedStatus.Pending)
            //{
            //    And(s => s.FlightSchedules.Count() > 0 && s.FlightSchedules.Where(x => x.AircraftId != null).Count() == 0);
            //}


            if (!isCount)
            {
                AddInclude(c => c.Include(v => v.FlightSchedules));
                AddInclude(x => x.Include(y => y.Flight).ThenInclude(z => z.FlightSectors));
                ApplyPaging(query.PageSize * (query.PageIndex - 1), query.PageSize);
            }
        }

        public FlightScheduleManagementSpecification(Guid AircraftSubTypeId)
            : base(x => x.AircraftSubTypeId == AircraftSubTypeId && !x.IsDeleted)
        {
            AddInclude(x => x.Include(y => y.Flight).ThenInclude(z => z.FlightSectors));
            AddInclude(x => x.Include(y => y.AircraftSubType));
            AddInclude(x => x.Include(y => y.FlightSchedules).ThenInclude(z => z.Aircraft));

        }

    }
}
