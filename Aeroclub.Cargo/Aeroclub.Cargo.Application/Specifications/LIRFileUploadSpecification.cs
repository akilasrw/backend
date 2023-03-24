using Aeroclub.Cargo.Application.Models.Queries.LIRFileUploadQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class LIRFileUploadSpecification : BaseSpecification<LIRFileUpload>
    {
        public LIRFileUploadSpecification(LIRFileUploadQM query) :
            base(x=> x.FlightScheduleId == query.FlightId )
        {

        }
    }
}
