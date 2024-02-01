using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.ViewModels.BookingShipmentSummeryVM
{
    public class BookingShipmentSummeryVM
    {
        public Guid shipmentID { get; set; }
        public DateTime bookedDate {  get; set; }
        public long awbNumber { get; set; }
        public PackageItemStatus shipmentStatus { get; set; }
        public int packageCount { get; set; }
        public string flightNumber { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public DateTime flightDate { get; set; }
        public DateTime? flightDep {  get; set; }
        public DateTime? flightArr {  get; set; }
        public DateTime? acceptedForFLight { get; set; }
        public DateTime? inDestinationWahouse { get; set; }
        public DateTime? deliverdToAgend { get; set; }
    }
}
