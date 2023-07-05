using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Extensions;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.SystemUserQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.SystemUserRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.SystemUserVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Core.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IManageUserService
    {
        Task<SystemUserVM> GetAsync(SystemUserQM query);
        Task<ServiceResponseCreateStatus> CreateAsync(SystemUserCreateRM model);
        Task<bool> StatusUpdateAsync(SystemUserStatusUpdateRM rm);
        Task<Pagination<SystemUserVM>> GetFilteredListAsync(SystemUserListQM query);
    }
}
