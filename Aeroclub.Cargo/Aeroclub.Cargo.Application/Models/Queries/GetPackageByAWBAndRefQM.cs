using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.Queries
{
    public class GetPackageByAWBAndRefQM
    {
        public string packageNum {  get; set; }
        public long awb {  get; set; }
    }
}
