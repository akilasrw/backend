using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.Dtos
{
    public class UnitDto: BaseDto
    {
        public string Name { get; set; }
        public UnitType UnitType { get; set; }
    }
}
