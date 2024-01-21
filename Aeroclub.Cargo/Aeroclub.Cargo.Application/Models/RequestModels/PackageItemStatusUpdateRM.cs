using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.RequestModels
{
    public class PackageItemStatusUpdateRM
    {
        public List<PackageItemListRM> itemList { get; set; }
        public long? AWBNumber { get; set; }
        public BookingStatus? status { get; set; }
    }
}
