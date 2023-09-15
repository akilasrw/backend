﻿using Aeroclub.Cargo.Application.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleSectorPalletRMs
{
    public class FlightScheduleSectorPalletCreateRM : BaseRM
    {
        public Guid FlightScheduleSectorId { get; set; }
        public Guid ULDId { get; set; }
    }
    public class FlightScheduleSectorPalletCreateRemoveRM : FlightScheduleSectorPalletCreateRM
    {
        public bool IsAdded { get; set; }
    }
    
    public class FlightScheduleSectorPalletCreateListRM
    {
        public IEnumerable<FlightScheduleSectorPalletCreateRemoveRM> FlightScheduleSectorPalletRMs { get; set; }
    }

    
}
