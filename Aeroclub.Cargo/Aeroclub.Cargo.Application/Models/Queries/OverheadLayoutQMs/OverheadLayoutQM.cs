using Aeroclub.Cargo.Application.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.Queries.OverheadLayoutQMs
{
    public class OverheadLayoutQM : BaseQM
    {
        public bool IncludeOverheadCompartment { get; set; }
        public bool IsBaseLayout { get; set; }
    }
}
