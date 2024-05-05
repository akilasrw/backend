using Aeroclub.Cargo.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.Queries.PackageQMs
{
    public class PackageListByAwbAndStatus
    {
        public PackageItemStatus[] packageItemStatuses {  get; set; }
        public long AwbNumber {  get; set; }
    }
}
