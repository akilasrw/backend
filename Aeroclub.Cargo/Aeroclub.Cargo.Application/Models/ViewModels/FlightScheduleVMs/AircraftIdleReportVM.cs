﻿using Aeroclub.Cargo.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleVMs
{
    public class AircraftIdleReportVM
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public double NoOfHours { get; set; }
        public string AircraftRegNo { get; set; }
        public Guid AircraftId { get; set; }
        public double? TotalFlightTimeHrs { get; set; }        
        public ScheduleStatus ScheduleStatus { get; set; }
        public IEnumerable<FlightLocationVM> FlightLocationsList { get; set; }
        public IEnumerable<ScheduleTimeVM> ScheduleTimeList { get; set; }
        public IEnumerable<AircraftIdleDateRange> AircraftIdleDateRangeList { get; set; }
    }
}