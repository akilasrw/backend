using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.RequestModels.PackageItemRMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IAssignCargoToULDService
    {
        Task<ServiceResponseCreateStatus> CreateAsync(ULDContainerCargoPositionDto package);
    }
}
