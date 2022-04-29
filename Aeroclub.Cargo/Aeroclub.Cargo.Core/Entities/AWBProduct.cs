using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class AWBProduct : AuditableEntity
    {
        public string? ProductRefNumber { get; set; } = null;
        public string ProductName { get; set; } = null!;
        public PackageProductType ProductType { get; set; }
        public int Quantity { get; set; }
        public Guid? AWBInformationId { get; set; }

        public virtual AWBInformation AWBInformation { get; set; }



    }
}
