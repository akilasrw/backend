using Aeroclub.Cargo.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.Queries.PackageItemQMs
{
    public class PackageItemByBookingQM
    {
        public Guid BookingID { get; set; }
        public PackageItemStatus? PackageItemStatus { get; set; }
    }
}
