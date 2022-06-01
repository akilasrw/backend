using System;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class ULDContainer : AuditableEntity
    {
        public Guid LoadPlanId { get; set; }
        public ULDContainerType ULDContainerType { get; set; }
        public double TotalWeight { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public Guid? ULDId { get; set; }

        public virtual LoadPlan LoadPlan { get; set; }
        public virtual ULD? ULD { get; set; }
        public virtual ICollection<PackageItem> PackageItems { get; set; }
        public virtual ICollection<ULDContainerCargoPosition> ULDContainerCargoPositions { get; set; }


    }
}