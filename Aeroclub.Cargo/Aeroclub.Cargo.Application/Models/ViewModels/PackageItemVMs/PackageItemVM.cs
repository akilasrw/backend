using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.ViewModels.AirWayBillVMs;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.ViewModels.PackageItemVMs
{
    public class PackageItemVM : BaseVM
    {
        public string? PackageRefNumber { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public double Height { get; set; }
        public Guid VolumeUnitId { get; set; }
        public double Weight { get; set; }
        public double ChargeableWeight { get; set; }
        public Guid WeightUnitId { get; set; }
        public double DeclaredValue { get; set; }
        public PackageItemStatus PackageItemStatus { get; set; }
        public string Description { get; set; }
        public PackageItemCategory PackageItemType { get; set; }
        public Guid ULDContainerId { get; set; }
        public PackagePriorityType PackagePriorityType { get; set; }
        public PackageItemCategory PackageItemCategory { get; set; }
        public Guid CargoBookingId { get; set; }
        public Guid? CargoPositionId { get; set; }

    }
}
