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
         : base(x => x.CargoAgentId == query.CargoAgentId && !x.IsSequenceCompleted)
        {
         
        }        

        public AWBStackSpecification(AWBStackListQM query, bool isCount = false)
            :base(x => ((string.IsNullOrEmpty(query.CargoAgentName) || x.CargoAgent.AgentName == query.CargoAgentName)) && !x.IsSequenceCompleted)
        {
            if (query.IsAgentInclude)
            {
                AddInclude(x => x.Include(y => y.CargoAgent));
            }

            if (!isCount)
            {
                ApplyPaging(query.PageSize * (query.PageIndex - 1), query.PageSize);
            }
        }
    }
}
