using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class AgentOtherRateSpecification : BaseSpecification<AgentOtherRates>
    {
        public AgentOtherRateSpecification(Guid query)
        : base(x => x.ChildCategoryID == query) { }
    }
}
