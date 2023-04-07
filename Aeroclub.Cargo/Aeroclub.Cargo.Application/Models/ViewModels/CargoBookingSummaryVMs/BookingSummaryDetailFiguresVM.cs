using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingSummaryVMs
{
    public class BookingSummaryDetailFiguresVM
    {
        public int BookingCount { get; set; }
        public int BookingRecievedCount { get; set; }
        public double TotalBookedWeight { get; set; }
        public double TotalBookedVolume { get; set; }
        public double TotalRecievedBookedWeight { get; set; }
        public double TotalRecievedBookedVolume { get; set; }
    }
}
