using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.Queries
{
    public class CheckAwbQM
    {
        public long awb {  get; set; }
        public Guid agentId { get; set; }
    }
}
