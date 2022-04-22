using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.ULDQMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IULDService
    {
        Task<ServiceResponseStatus> CreateAsync(ULDDto ULDDto);
        Task<ULDDto> GetAsync(ULDQM query);
    }
}
