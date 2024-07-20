using Aeroclub.Cargo.Application.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.Queries.CargoBookingQMs
{
    public class StandbyCargoBookingsQM : BasePaginationQM
    {
        public Guid CargoAgent {  get; set; }
        public string? CargoBooking { get; set; }
    }
}
