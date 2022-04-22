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
    public class ULDDto: BaseDto
    {
        [Required]
        public ULDType ULDType { get; set; }
        public string SerialNumber { get; set; } = null!;

        public Guid ULDMetaDataId { get; set; }
        public ULDMetaDataDto ULDMetaData { get; set; }
    }
}
