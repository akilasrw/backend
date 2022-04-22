using Aeroclub.Cargo.Application.Models.Queries.ULDMetaDataQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class ULDMetaDataSpecification : BaseSpecification<ULDMetaData>
    {
        public ULDMetaDataSpecification(ULDMetaDataQM query)
            : base(x=> (query.Height != 0 && query.Height == x.Height) &&
                    query.Weight != 0 && query.Weight == x.Height &&
                    query.Length != 0 && query.Length == x.Length &&
                    query.Width != 0 && query.Width == x.Width)
        {

        }
    }
}
