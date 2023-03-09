using Aeroclub.Cargo.Application.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleRMs
{
    public class UpdateATARM : BaseRM
    {
        public Guid? FlightId { get; set; }
        public string ActualArrivalDateTime { get; set; }
    }
}
