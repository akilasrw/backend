using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.RequestModels
{
    public class PackageUpdateByULD
    {
        public Guid[] ulds { get; set; }

        public bool IsArrived { get; set; }
    }
}
