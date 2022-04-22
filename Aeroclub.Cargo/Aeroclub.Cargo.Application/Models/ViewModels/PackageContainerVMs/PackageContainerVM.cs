using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.ViewModels.PackageContainerVMs
{
    public class PackageContainerVM : BaseVM
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public bool IsCustom { get; set; }
        public CargoPositionType CargoPositionType { get; set; }
        public PackageContainerType? PackageContainerType { get; set; }
        public PackageItemCategory PackageItemCategory { get; set; }
        public PackageBoxType PackageBoxType { get; set; }
        public double MaxWaight { get; set; }
    }
}
