using Aeroclub.Cargo.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.Queries.ItemAuditQM
{
    public class ItemAuditQM
    {
        public Guid bookingID { get; set; }
        public PackageItemStatus status { get; set; }
    }
}
