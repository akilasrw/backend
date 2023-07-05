using Aeroclub.Cargo.Application.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.Queries.SystemUserQMs
{
    public class SystemUserQM : BaseQM
    {
        public Guid AppUserId { get; set; }
    }
}
