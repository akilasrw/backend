using Aeroclub.Cargo.Application.Models.Queries.AircraftQMs;
using Aeroclub.Cargo.Application.Models.Queries.CargoAgentQMs;
using Aeroclub.Cargo.Application.Models.Queries.SystemUserQMs;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class SystemUserSpecification : BaseSpecification<SystemUser>
    {
        public SystemUserSpecification(SystemUserQM query)
            : base(x=>((query.Id == Guid.Empty || x.Id == query.Id) && (query.AppUserId == Guid.Empty || x.AppUserId == query.AppUserId)))
        {

        }



        public SystemUserSpecification(SystemUserListQM query, bool isCount = false)
          : base(x => (string.IsNullOrEmpty(query.Name) || x.AppUser.FirstName.Contains(query.Name) || x.AppUser.LastName.Contains(query.Name)) &&
          (query.Status == UserStatus.None || x.UserStatus == query.Status) && (x.IsDeleted == false)
          )
        {

            if (!isCount)
            {
                AddInclude(d => d.Include(s => s.AppUser));

                if (query.IsCountryInclude)
                    AddInclude(x => x.Include(x => x.Country));

                AddInclude(x => x.Include(x => x.BaseAirport));

                ApplyPaging(query.PageSize * (query.PageIndex - 1), query.PageSize);
                AddOrderByDescending(x => x.Created);
            }
        }
    }
}
