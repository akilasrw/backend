using Aeroclub.Cargo.Application.Models.Queries.AWBStackQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;


namespace Aeroclub.Cargo.Application.Specifications
{
    public class AWBStackSpecification : BaseSpecification<AWBStack>
    {
        public AWBStackSpecification(AWBStackQM query)
            : base(x => x.Id == query.Id)
        {
            if (query.IsAgentInclude)
            {
                AddInclude(x => x.Include(y => y.CargoAgent));
            }

        }

        public AWBStackSpecification(AWBNumberStackQM query)
         : base(x => x.CargoAgent.AppUserId == query.CargoAgentId && !x.IsSequenceCompleted)
        {
            AddInclude(x => x.Include(y => y.CargoAgent));
        }        

        public AWBStackSpecification(AWBStackListQM query, bool isCount = false)
            :base(x => ((string.IsNullOrEmpty(query.CargoAgentName) || x.CargoAgent.AgentName == query.CargoAgentName)) && !x.IsSequenceCompleted)
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
