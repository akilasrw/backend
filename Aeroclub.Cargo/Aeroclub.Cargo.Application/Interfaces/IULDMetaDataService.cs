using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.ULDMetaDataQMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IULDMetaDataService
    {
        Task<ServiceResponseCreateStatus> CreateAsync(ULDMetaDataDto dto);
        Task<ULDMetaDataDto> GetAsync(ULDMetaDataQM query);
    }
}
