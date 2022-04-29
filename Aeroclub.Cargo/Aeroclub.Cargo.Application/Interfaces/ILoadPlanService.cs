using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.LoadPlanQMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface ILoadPlanService
    {
        Task<ServiceResponseCreateStatus> CreateAsync(LoadPlanDto loadPlanDto);
        Task<LoadPlanDto> GetAsync(LoadPlanQM query);
    }
}
