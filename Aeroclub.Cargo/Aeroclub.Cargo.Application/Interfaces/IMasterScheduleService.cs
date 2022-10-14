﻿using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.MasterScheduleQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.MasterScheduleRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.MasterScheduleVMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IMasterScheduleService
    {
        Task<ServiceResponseCreateStatus> CreateAsync(MasterScheduleRM dto);
        Task<MasterScheduleVM> GetAsync(MasterScheduleDetailQM query);


    }
}
