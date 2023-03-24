using Aeroclub.Cargo.Application.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.Dtos
{
    public class LIRFileUploadDto: BaseDto
    {
        public Guid FlightScheduleId { get; set; }
        public string FileName { get; set; } = null!;
        public string FileURLPath { get; set; } = null!;
        public string? FileFullURL { get; set; } = null;
        public string? Extesnsion { get; set; } = null;
    }
}
