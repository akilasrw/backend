using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.ViewModels.CargoPositionVMs
{
    public class CargoPositionDetailVM
    {
        public bool IsPalletAssigned { get; set; }
        public string? ULDNumber { get; set; }
        public double MaxWeight { get; set; }
        public double Weight { get; set; }
        public double Volume { get; set; }
        public double MaxVolume { get; set; }
        public string Destination { get; set; }
    }
}
