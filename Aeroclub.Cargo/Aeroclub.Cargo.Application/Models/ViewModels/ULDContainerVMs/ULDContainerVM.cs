using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.ViewModels.ULDVMs;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.ViewModels.ULDContainerVMs
{
    public class ULDContainerVM : BaseVM
    {
        public Guid LoadPlanId { get; set; }
        public ULDContainerType ULDContainerType { get; set; }
        public double TotalWeight { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }
        public Guid? ULDId { get; set; }

        public  ULDVM? ULD { get; set; }

    }
}
