using System;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class PackageItem : AuditableEntity
    {
        public string PackageRefNumber { get; set; } = null!; // Auto Generated No - Format - Singleton
        public PackagePriorityType? PackagePriorityType { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public double Height { get; set; }
        public Guid? VolumeUnitId { get; set; }
        public double Weight { get; set; }
        public double ChargeableWeight { get; set; }
        public Guid? WeightUnitId { get; set; }
        public double DeclaredValue { get; set; }
        public PackageItemStatus PackageItemStatus { get; set; }
        public string? Description { get; set; }
        public PackageItemCategory? PackageItemCategory { get; set; }
        public Guid CargoBookingId { get; set; }
        public Guid? ShipmentId { get; set; }
        public Shipment Shipment { get; set; }

        public virtual CargoBooking CargoBooking { get; set; }
        public virtual Unit VolumeUnit { get; set; }
        public virtual Unit WeightUnit { get; set; }
        public virtual ICollection<PackageULDContainer> PackageULDContainers { get;}
    }
}