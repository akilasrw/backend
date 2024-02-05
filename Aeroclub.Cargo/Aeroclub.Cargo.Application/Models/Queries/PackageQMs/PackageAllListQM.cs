using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.Queries.PackageQMs
{
    public class PackageAllListQM
    {
        public bool IncludeCargoBooking { get; set; }

        public long? awbNumber { get; set; }
    }
}
