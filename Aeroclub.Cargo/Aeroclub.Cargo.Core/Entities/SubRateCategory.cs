using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Aeroclub.Cargo.Core.Entities
{
    public class SubRateCategory : BaseEntity
    {
        public string CategoryName { get; set; }
        public OtherRateTypes CategoryType { get; set; }
    }
}