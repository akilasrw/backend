using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.Dtos
{
    public class ULDContainerDto: BaseDto
    {
        public Guid? ULDId { get; set; }
        [Required]
        public Guid LoadPlanId { get; set; }
        [Required]
        public Guid CargoPositionId { get; set; }
        public ULDContainerType ULDContainerType { get; set; }
        public double TotalWeight { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
    }
}
