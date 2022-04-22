using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.SeatQMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface ISeatService
    {
        Task<ServiceResponseStatus> UpdateAsync(SeatDto seatDto);
        Task<SeatDto> GetAsync(SeatQM query);
    }
}
