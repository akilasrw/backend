using Aeroclub.Cargo.Application.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleVMs
{
    public class FlightScheduleLinkVM: BaseVM
    {
        public Guid? AircraftId { get; set; }
        public Guid FlightScheduleManagementId { get; set; }
        public DateTime ScheduledDepartureDateTime { get; set; }
    }
}
