﻿using System;
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
        public Guid? AircraftScheduleId { get; set; }
        public string? EstimatedDepartureDateTime { get; set; }
        public string? EstimatedArrivalDateTime { get; set; }
        public string? ActualDepartureDateTime { get; set; }
        public byte? StepCount { get; set; }
        public bool? IsDispatched { get; set; }
    }

    public class VerifyScheduleAicraftRM
    {
        public Guid FlightScheduleId { get; set; }
    }

}
