using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.Dtos
{
    public class SeatConfigurationDto: BaseDto
    {
        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }
        public SeatConfigurationType SeatConfigurationType { get; set; }
        public bool IsOnSeatOccupied { get; set; }
        public bool IsUnderSeatOccupied { get; set; }
        public bool IsFullRowOccupied { get; set; }
        public double MaxWeight { get; set; }
        public Guid? SeatLayoutId { get; set; }

        public virtual IEnumerable<SeatDto> Seats { get; set; }
    }
}
