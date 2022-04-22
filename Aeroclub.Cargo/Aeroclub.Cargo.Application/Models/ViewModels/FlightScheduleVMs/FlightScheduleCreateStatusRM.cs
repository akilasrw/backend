using Aeroclub.Cargo.Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleVMs
{
    public class FlightScheduleCreateStatusRM
    {
        public Guid Id { get; set; }
        public ServiceResponseStatus StatusCode { get; set; }
    }
}
