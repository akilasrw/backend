using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.RequestModels.FlightRMs
{
    public class FlightCreateRM
    {
        [Required(ErrorMessage = "Flight Number is required.")]
        public string FlightNumber { get; set; } = null!;

        public IEnumerable<FlightSectorDto>? FlightSectors { get; set; } = null;
    }
}
