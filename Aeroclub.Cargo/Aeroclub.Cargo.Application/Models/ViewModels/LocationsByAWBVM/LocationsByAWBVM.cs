using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.ViewModels.LocationsByAWBVM
{
    public class LocationsByAWBVM
    {
        public Guid originId { get; set; }
        public string originName { get; set; }

        public Guid destinationId { get; set; }
        public string destinationName { get; set; }
    }
}
