using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.RequestModels.GetShipmentsRM
{
    public class GetShipmentsRM
    {
        public long? AWBNumber { get; set; }
        public string? packageID { get; set; }
    }
}
