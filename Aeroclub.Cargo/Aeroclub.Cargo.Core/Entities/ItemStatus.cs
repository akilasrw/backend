using System;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class ItemStatus : AuditableEntity
    {
       public Guid PackageID { get; set; }
       public PackageItemStatus PackageItemStatus { get; set; }
    }
}