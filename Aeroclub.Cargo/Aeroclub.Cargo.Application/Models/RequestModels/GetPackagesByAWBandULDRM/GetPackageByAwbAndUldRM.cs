using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.RequestModels.GetPackagesByAWBandULDRM
{
    public class GetPackageByAwbAndUldRM
    {
        public long? AwbNumber {  get; set; }
        public string uld {  get; set; }
    }
}
