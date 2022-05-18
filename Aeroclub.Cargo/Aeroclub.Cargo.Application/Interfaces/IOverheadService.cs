using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.OverheadPositionQMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IOverheadService
    {
        Task<ServiceResponseStatus> UpdateAsync(OverheadPositionDto overheadPositionDto);
        Task<OverheadPositionDto> GetAsync(OverheadPositionQM query);
    }
}
