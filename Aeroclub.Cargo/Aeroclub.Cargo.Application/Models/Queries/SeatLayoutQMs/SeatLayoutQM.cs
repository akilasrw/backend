using Aeroclub.Cargo.Application.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.Queries.SeatLayoutQMs
{
    public class SeatLayoutQM : BaseQM
    {
        public bool IncludeSeatConfiguration { get; set; }
        public bool IsBaseLayout { get; set; }
    }
}
