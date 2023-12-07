using Aeroclub.Cargo.Application.Models.Dtos;
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
    public class ULDCargoPositionSpecification : BaseSpecification<ULDCargoPosition>
    {
        public ULDCargoPositionSpecification(ULDCargoPositionDto query)
            : base(x => x.ULDId == query.ULDId || x.CargoPositionId == query.CargoPositionId)
        {

        }
    }
}
