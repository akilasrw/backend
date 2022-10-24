using Aeroclub.Cargo.Application.Models.Queries.AWBNumberStackQMs;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class AWBNumberStackSpecification : BaseSpecification<AWBNumberStack>
    {
        public AWBNumberStackSpecification(AWBNumberStackQM query)
           : base(x => x.Id == query.Id)
        {
            if (query.IsAgentInclude)
            {
                AddInclude(x => x.Include(y => y.CargoAgent));
            }

        }

        public AWBNumberStackSpecification(AWBNumberStackListQM query, bool isCount = false)
            : base(x => (string.IsNullOrEmpty(query.CargoAgentName) || x.CargoAgent.AgentName.Contains(query.CargoAgentName)) &&
            (query.AWBNumberStatus == AWBNumberStatus.All || ((query.AWBNumberStatus == AWBNumberStatus.Used) ? x.IsUsed : !x.IsUsed)))
        {

            if (!isCount)
            {
                if (query.IsAgentInclude)
                {
                    AddInclude(x => x.Include(y => y.CargoAgent));
                }
                ApplyPaging(query.PageSize * (query.PageIndex - 1), query.PageSize);
                AddOrderByDescending(x => x.Created);
            }
        }
    }
}
