using Aeroclub.Cargo.Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.Core
{
    public class CargoPositionClearResponse
    {
        public ServiceResponseStatus StatusCode { get; set; }
        public string? Message { get; set; }


    }
}
