using Aeroclub.Cargo.Application.Models.Queries.CargoAgentQMs;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class CargoAgentSpecification : BaseSpecification<CargoAgent>
    {
        public CargoAgentSpecification(CargoAgentQM query)
            : base(x=>( (query.Id == Guid.Empty || x.Id == query.Id) && (query.AppUserId == Guid.Empty || x.AppUserId == query.AppUserId)))
        {

            AddInclude(d => d.Include(s => s.AppUser));

            if (query.IsCountryInclude)
                AddInclude(x => x.Include(x => x.Country));

        }

        public CargoAgentSpecification(CargoAgentListQM query, bool isCount = false)
            : base(x => (string.IsNullOrEmpty(query.CargoAgentName) || x.AgentName.Contains(query.CargoAgentName)) &&
            (query.Status == CargoAgentStatus.None ||x.Status == query.Status)
            )
        {

            if (!isCount)
            {
                AddInclude(d => d.Include(s => s.AppUser));

                if (query.IsCountryInclude)
                    AddInclude(x => x.Include(x => x.Country));

                if(query.IsAirportInclude)
                    AddInclude(x => x.Include(x => x.BaseAirport));

                ApplyPaging(query.PageSize * (query.PageIndex - 1), query.PageSize);
                AddOrderByDescending(x => x.Created);
            }
           

        }

    }
    
}
