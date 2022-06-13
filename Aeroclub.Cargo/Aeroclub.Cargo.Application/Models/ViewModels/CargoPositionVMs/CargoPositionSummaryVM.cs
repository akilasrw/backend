﻿using Aeroclub.Cargo.Application.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.ViewModels.CargoPositionVMs
{
    public class CargoPositionSummaryVM : BaseVM
    {
        public double TotalBookedWeight { get; set; }
        public double TotalWeight { get; set; }
        public double WeightPercentage { get; set; }

        public int TotalOccupiedOnSeats { get; set; }
        public int TotalOnSeats { get; set; }
        public double OnSeatsPercentage { get; set; }


        public int TotalOccupiedUnderSeats { get; set; }
        public int TotalUnderSeats { get; set; }
        public double UnderSeatsPercentage { get; set; }

        public int TotalOccupiedOverheads { get; set; }
        public int TotalOverheads { get; set; }
        public double OverheadPercentage { get; set; }


    }
}
