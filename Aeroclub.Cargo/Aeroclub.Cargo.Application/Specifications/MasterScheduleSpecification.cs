using Aeroclub.Cargo.Application.Models.Queries.MasterScheduleQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class MasterScheduleSpecification : BaseSpecification<MasterSchedule>
    {
        public MasterScheduleSpecification(MasterScheduleDetailQM query)
             : base(x => x.Id == query.Id && !x.IsDeleted)
        {

        }
    }
}
