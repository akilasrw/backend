﻿using System;
using System.Collections.Generic;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class CargoPosition : AuditableEntity
    {
        public string Name { get; set; } = null!;
        public Guid ZoneAreaId { get; set; }
        public CargoPositionType CargoPositionType { get; set; }
        public double MaxWeight { get; set; }
        public double CurrentWeight { get; set; }
        public Guid? SeatId { get; set; }
        public Guid? OverheadCompartmentId { get; set; }

        public virtual ZoneArea ZoneArea { get; set; }
        public virtual Seat Seat { get; set; }
        public virtual OverheadCompartment OverheadCompartment { get; set; }
        public virtual ICollection<ULDContainer> ULDContainers { get; set; }
    }
}