using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.LIRFileUploadQMs;
using Aeroclub.Cargo.Application.Models.Queries.SectorQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.SectorRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.SectorVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface ILIRFileUploadService
    {
        Task<ServiceResponseCreateStatus> CreateAsync(LIRFileUploadDto model);
        Task<LIRFileUploadDto> GetAsync(LIRFileUploadQM query);
        Task<ServiceResponseStatus> UpdateAsync(LIRFileUploadDto model);
    }
}
