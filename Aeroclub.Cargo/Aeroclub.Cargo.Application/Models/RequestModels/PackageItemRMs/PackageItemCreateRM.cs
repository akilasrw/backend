using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.RequestModels.PackageItemRMs
{
    public class PackageItemCreateRM
    {
        public Guid? CargoBookingId { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public double Height { get; set; }
        public Guid VolumeUnitId { get; set; }
        public double Weight { get; set; }
        public double Volume { get; set; }
        public int Pieces { get; set; }
        public Guid WeightUnitId { get; set; }
        public double DeclaredValue { get; set; }
        public PackageItemCategory PackageItemCategory { get; set; }
        public PackagePriorityType PackagePriorityType { get; set; }
        public PackageContainerType PackageContainerType { get; set; } = PackageContainerType.None;
        public PackageItemStatus packageItemStatus { get; set; }
        public string? Description { get; set; }
        public Guid? ULDContainerId { get; set; }
    }
}