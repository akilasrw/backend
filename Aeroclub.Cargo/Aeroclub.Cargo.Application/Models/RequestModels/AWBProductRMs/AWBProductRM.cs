

using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.RequestModels.AirWayBillRMs
{
    public class AWBProductRM : BaseRM
    {
        public string? ProductRefNumber { get; set; } = null;
        public string ProductName { get; set; } = null!;
        public PackageProductType ProductType { get; set; }
        public int Quantity { get; set; }
    }
}
