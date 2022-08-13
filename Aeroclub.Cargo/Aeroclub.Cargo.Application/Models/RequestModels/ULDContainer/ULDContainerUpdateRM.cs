using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace Aeroclub.Cargo.Application.Models.RequestModels.ULDContainer
{
    public class ULDContainerUpdateRM : BaseRM
    {
        public Guid? ULDId { get; set; }
        [Required]
        public Guid LoadPlanId { get; set; }
        public ULDContainerType ULDContainerType { get; set; }
        public double TotalWeight { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }
    }
}
