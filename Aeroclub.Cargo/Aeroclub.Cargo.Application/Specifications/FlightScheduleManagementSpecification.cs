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
            AddInclude(x => x.Include(y => y.Flight).ThenInclude(z => z.FlightSectors));

            if (!isCount)
                ApplyPaging(query.PageSize * (query.PageIndex - 1), query.PageSize);
        }

        public FlightScheduleManagementSpecification(FlightScheduleManagementDetailQM query)
            : base(x => x.Id == query.Id && !x.IsDeleted)
        {
            AddInclude(x => x.Include(y => y.Flight).ThenInclude(z => z.FlightSectors));

        }


    }
}
