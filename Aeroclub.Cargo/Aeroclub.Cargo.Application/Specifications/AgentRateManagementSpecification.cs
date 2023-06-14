using Aeroclub.Cargo.Application.Models.Queries.AgentRateManagementQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class AgentRateManagementSpecification : BaseSpecification<AgentRateManagement>
    {
        public AgentRateManagementSpecification(AgentRateManagementListQM query, bool isCount = false)
            : base(x => (query.CargoAgentId == Guid.Empty || x.CargoAgentId == query.CargoAgentId) &&
            (query.OriginAirportId == Guid.Empty || x.OriginAirportId == query.OriginAirportId) &&
            (query.DestinationAirportId == Guid.Empty || x.DestinationAirportId == query.DestinationAirportId) &&
            !x.IsDeleted)
        {
            if (!isCount)
            {
                AddInclude(x => x.Include(y => y.CargoAgent));

                ApplyPaging(query.PageSize * (query.PageIndex - 1), query.PageSize);
                AddOrderByDescending(x => x.Created);
            }
        }

        public AgentRateManagementSpecification(AgentRateManagementRateListQM query, bool isCount = false)
        : base(x => (x.CargoAgent != null &&  x.CargoAgent.AppUserId == query.UserId )&&
        (query.OriginAirportId == Guid.Empty || x.OriginAirportId == query.OriginAirportId) &&
        (query.DestinationAirportId == Guid.Empty || x.DestinationAirportId == query.DestinationAirportId) &&
        !x.IsDeleted)
        {
            if (!isCount)
            {
                AddInclude(x => x.Include(y => y.CargoAgent));
                AddInclude(x => x.Include(y => y.AgentRates));

                ApplyPaging(query.PageSize * (query.PageIndex - 1), query.PageSize);
                AddOrderByDescending(x => x.Created);
            }
        }

        

        public AgentRateManagementSpecification(AgentRateManagementValidationQM query)
            :base(x => (query.CargoAgentId == Guid.Empty || x.CargoAgentId == query.CargoAgentId) && x.OriginAirportId == query.OriginAirportId &&
            x.DestinationAirportId == query.DestinationAirportId && 
            ((query.ValidStartDate.Date >= x.StartDate.Date && query.ValidStartDate.Date <= x.EndDate.Date) ||
            (query.ValidEndDate.Date >= x.StartDate.Date && query.ValidEndDate.Date <= x.EndDate.Date)) &&
            !x.IsDeleted)
        {
            if(query.IncludeAgentRates)
                AddInclude(x => x.Include(y => y.AgentRates));
        }
        
        public AgentRateManagementSpecification(AgentRateManagementUpdateQM query)
            :base(x => (query.CargoAgentId == Guid.Empty || x.CargoAgentId == query.CargoAgentId) && x.OriginAirportId == query.OriginAirportId &&
            x.DestinationAirportId == query.DestinationAirportId && 
            query.ValidStartDate.Date == x.StartDate.Date && query.ValidEndDate.Date <= x.EndDate.Date &&
            !x.IsDeleted)
        {
            if(query.IncludeAgentRates)
                AddInclude(x => x.Include(y => y.AgentRates));
        }

        public AgentRateManagementSpecification(AgentRateManagementQM query)
           : base(x => x.Id == query.Id)
        {

            AddInclude(x => x.Include(y => y.AgentRates));

            if (query.IncludeCargoAgent)
                AddInclude(x => x.Include(y => y.CargoAgent));

        }

    }

}
