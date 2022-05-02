using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.ViewModels.AWBProductVMs
{
    public class AWBProductVM :BaseVM
    {
        public string? ProductRefNumber { get; set; } = null;
        public string ProductName { get; set; } = null!;
        public PackageProductType ProductType { get; set; }
        public int Quantity { get; set; }
        public Guid? AWBInformationId { get; set; }
    }
}
