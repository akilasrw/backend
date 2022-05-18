using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.Dtos
{
    public class LoadPlanDto : BaseDto
    {
        [Required]
        public LoadPlanStatus LoadPlanStatus { get; set; }
        public Guid AircraftLayoutId { get; set; }
        public Guid SeatLayoutId { get; set; }
        public Guid OverheadLayoutId { get; set; }
    }
}
