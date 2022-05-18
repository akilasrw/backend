using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.SeatConfigurationQMs;
using Aeroclub.Cargo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface ISeatConfigurationService
    {
        Task<SeatConfigurationDto> GetAsync(SeatConfigurationQM query);
        Task<ServiceResponseStatus> UpdateAsync(SeatConfigurationDto seatConfigurationDto);
    }
}
