﻿using Aeroclub.Cargo.Application.Models.Core;

namespace Aeroclub.Cargo.Application.Models.Queries.CargoBookingQMs
{
    public class CargoBookingDetailQM : BaseQM
    {
        public bool IsIncludeFlightDetail { get; set; }
        public bool IsIncludePackageDetail { get; set; }
        public Guid UserId { get; set; }
    }
}
