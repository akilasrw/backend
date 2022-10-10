using Aeroclub.Cargo.Application.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.Dtos
{
    public class CountryDto: BaseDto
    {
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string? CodeISO3166 { get => Code != null ? Code.Substring(0, 2) : CodeISO3166; }
    }
}
