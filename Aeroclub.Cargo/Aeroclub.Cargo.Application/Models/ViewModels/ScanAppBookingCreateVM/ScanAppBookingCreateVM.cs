using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.ViewModels.ScanAppBookingCreateVM
{
    public class ScanAppBookingCreateVM
    {
        public string TruckNo { get; set; }
        public Guid CargoAgent {  get; set; }
        public Guid CargoAgentAppUserId { get; set; }
        public Guid Origin { get; set; }
        public Guid Destination { get; set; }
        public long AWBTrackingNumber { get; set; }
        public string[] Packages { get; set; }
    }
}
