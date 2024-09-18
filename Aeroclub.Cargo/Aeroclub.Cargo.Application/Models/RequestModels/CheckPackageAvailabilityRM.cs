using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.RequestModels
{
    public class CheckPackageAvailabilityRM
    {
        public string PackageRef {get; set; }
        public long AwbNumber { get; set; }
    }
}
