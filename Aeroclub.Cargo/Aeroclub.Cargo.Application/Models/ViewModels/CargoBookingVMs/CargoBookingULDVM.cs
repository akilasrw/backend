using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.ViewModels.PackageItemVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingVMs
{
    public class CargoBookingULDVM : BaseVM
    {
        public string BookingNumber { get; set; } = null!;
        public int AwbTrackingNumber { get; set; }
        public double TotalWeight { get; set; }
        public double TotalVolume { get; set; }
        public IReadOnlyList<PackageItemVM> PackageItems { get; set; }
    }
}
