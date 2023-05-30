using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.RequestModels.PackageULDContainerRM
{
    public class BookingAssignmentRM
    {
        public Guid PackageId { get; set; }
        public Guid uldId { get; set; }
    }
}
