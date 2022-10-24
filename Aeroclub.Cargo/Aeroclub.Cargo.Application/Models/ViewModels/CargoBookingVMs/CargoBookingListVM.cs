using Aeroclub.Cargo.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingVMs
{
    public class CargoBookingListVM
    {
        public string BookingNumber { get; set; } = null!;
        public string AWBNumber { get; set; }
        public string BookingAgent { get; set; }
        public DateTime BookingDate { get; set; }
        public BookingStatus BookingStatus { get; set; }
        public int NumberOfBoxes { get; set; }
        public double TotalWeight { get; set; }
        public double TotalVolume { get; set; }

    }
}
