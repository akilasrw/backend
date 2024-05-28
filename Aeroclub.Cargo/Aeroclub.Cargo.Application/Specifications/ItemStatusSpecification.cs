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
    public class ItemStatusSpecification : BaseSpecification<ItemStatus>
    {
        public ItemStatusSpecification(PackageItemStatus? status , long? awbNum)
            :base(x=> (status == null || x.PackageItemStatus == status) && (awbNum == null || awbNum == x.packageItem.CargoBooking.AWBInformation.AwbTrackingNumber) && x.IsDeleted == false) {

            AddInclude(x => x.Include(y => y.packageItem));
         
        }

        public ItemStatusSpecification(PackageItemStatus? status, Guid? packageId)
            : base(x => (status == null || x.PackageItemStatus == status) && (packageId == null || packageId == x.packageItem.Id) && x.IsDeleted == false)
        {

        }
    }
}
