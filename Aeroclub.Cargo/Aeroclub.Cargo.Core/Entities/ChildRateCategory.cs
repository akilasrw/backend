using Aeroclub.Cargo.Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Core.Entities
{
    public class ChildRateCategory : BaseEntity
    {
        public string CategoryName { get; set; }
        public Guid CategoryID { get; set; }
        public SubRateCategory SubRateCategory { get; set; }
    }
}
