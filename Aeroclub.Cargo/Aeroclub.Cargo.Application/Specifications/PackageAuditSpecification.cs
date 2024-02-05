using Aeroclub.Cargo.Application.Models.Queries.ItemAuditQM;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class PackageAuditSpecification : BaseSpecification<ItemStatus>
    {
        public PackageAuditSpecification(PackageItemStatus status, Guid packageID)
         :base(x => x.PackageItemStatus == status && x.PackageID == packageID)
        { }

        public PackageAuditSpecification(ItemAuditQM query)
         : base(x => (query.status == null || x.PackageItemStatus == query.status) && x.packageItem.CargoBookingId == query.bookingID)
        {
            AddInclude(x => x.Include(x => x.packageItem));
        }
    }
}
