using Aeroclub.Cargo.Application.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.Dtos
{
    public class SeatDto: BaseDto
    {
        public string SeatNumber { get; set; } = null!;
        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }
        public Guid ZoneAreaId { get; set; }
        public Guid SeatConfigurationId { get; set; }
        public bool IsOnSeatOccupied { get; set; }
        public bool IsUnderSeatOccupied { get; set; }
    }
}
