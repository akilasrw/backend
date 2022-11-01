using Aeroclub.Cargo.Application.Models.Queries.ULDContainerQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class ULDContainerSpecification : BaseSpecification<ULDContainer>
    {
        public ULDContainerSpecification(ULDContainerQM query)
            :base(x=>x.Id == query.Id)
        {
            AddInclude(y => y.Include(z => z.PackageItems));
        }
    }
}
