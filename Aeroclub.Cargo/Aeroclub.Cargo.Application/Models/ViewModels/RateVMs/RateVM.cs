using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.ViewModels.RateVMs
{
    public class RateVM:BaseVM
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public double MaxWaight { get; set; }
        public PackageContainerType PackageContainerType { get; set; }
        public PackageBoxType PackageBoxType { get; set; }
        public double Rate { get; set; }
    }
}
