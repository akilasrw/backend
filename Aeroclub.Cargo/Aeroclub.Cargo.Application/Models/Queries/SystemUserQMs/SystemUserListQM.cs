using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.Queries.SystemUserQMs
{
    public class SystemUserListQM : BasePaginationQM
    {
        public UserStatus Status { get; set; }
        public string Name { get; set; }
        public bool IsCountryInclude { get; set; }
    }
}
