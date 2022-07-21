using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.OverheadCompartmentQMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IOverheadService
    {
        Task<ServiceResponseStatus> UpdateAsync(OverheadCompartmentDto overheadCompartmentDto);
        Task<OverheadCompartmentDto> GetAsync(OverheadCompartmentQM query);
    }
}
