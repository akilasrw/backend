using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleManagementRMs
{
    public class ScheduleAircraftRM
    {
        public Guid FlightScheduleId { get; set; }

        [Required(ErrorMessage = "Aircraft is required.")]
        public Guid AircraftId { get; set; }
    }
}
