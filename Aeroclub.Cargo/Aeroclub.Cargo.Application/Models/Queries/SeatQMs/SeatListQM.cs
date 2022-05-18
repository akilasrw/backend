using Aeroclub.Cargo.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.Queries.SeatQMs
{
    public class SeatListQM
    {
        public Guid? ZoneAreaId { get; set; }
        public SeatConfigurationType SeatConfigurationType { get; set; } = SeatConfigurationType.None;
    }
}
