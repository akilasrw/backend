using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleManagementQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace Aeroclub.Cargo.Application.Specifications
{
    internal class FlightScheduleManagementSpecification : BaseSpecification<FlightScheduleManagement>
    {

        public FlightScheduleManagementSpecification(FlightScheduleManagementFilteredListQM query, bool isCount = false)
        : base(x =>(query.OriginAirportId == Guid.Empty || (x.Flight != null && x.Flight.OriginAirportId == query.OriginAirportId)) &&
       (query.DestinationAirportId == Guid.Empty || (x.Flight != null && x.Flight.DestinationAirportId == query.DestinationAirportId)) &&
        (string.IsNullOrEmpty(query.FlightNumber) || (x.Flight != null && x.Flight.FlightNumber.Contains(query.FlightNumber))))
        {

            if (!isCount)
            {
                AddInclude(x => x.Include(y => y.Flight).ThenInclude(z => z.FlightSectors));
                AddInclude(x => x.Include(y => y.AircraftSubType));
                ApplyPaging(query.PageSize * (query.PageIndex - 1), query.PageSize);
                AddOrderByDescending(x => x.Created);
            }

        }

        public FlightScheduleManagementSpecification(FlightScheduleManagementDetailQM query)
            : base(x => x.Id == query.Id && !x.IsDeleted)
        {
            AddInclude(x => x.Include(y => y.Flight).ThenInclude(z => z.FlightSectors));
            AddInclude(x => x.Include(y => y.AircraftSubType));

        }

        public FlightScheduleManagementSpecification(FlightScheduleManagemenLinktFilteredListQM query, bool isCount = false)
            : base(x=> (string.IsNullOrEmpty(query.FlightNumber) || (x.Flight != null && x.Flight.FlightNumber.Contains(query.FlightNumber))))
        {
            if (!isCount)
                ApplyPaging(query.PageSize * (query.PageIndex - 1), query.PageSize);
        }

    }
}
