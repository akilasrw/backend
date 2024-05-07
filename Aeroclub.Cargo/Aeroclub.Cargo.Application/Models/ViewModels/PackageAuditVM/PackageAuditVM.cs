using Aeroclub.Cargo.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.ViewModels.PackageAuditVM
{
    public class PackageAuditVM
    {
        public Guid packageId { get; set; }
        public string packageNumber { get; set; }
        public string collectedDate { get; set; }
        public PackageItemStatus packageStatus { get; set; }
        public long awb {  get; set; }
        public string flightNumber { get; set; }
        public DateTime flightDate { get; set; }
    }
}
