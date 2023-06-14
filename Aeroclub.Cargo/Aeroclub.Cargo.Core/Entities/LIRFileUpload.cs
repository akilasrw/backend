﻿using Aeroclub.Cargo.Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Core.Entities
{
    public class LIRFileUpload: AuditableEntity
    {
        public Guid FlightScheduleId { get; set; }
        public string FileName { get; set; } = null!;
        public string OriginalFileName { get; set; } = null!;
        public string FileURLPath { get; set; } = null!;
        public string? FileFullURL { get; set; } = null;
        public string? Extesnsion { get; set; } = null;

        public FlightSchedule FlightSchedule { get; set; }
    }
}
