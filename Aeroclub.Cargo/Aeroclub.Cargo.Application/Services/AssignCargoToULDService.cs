using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.RequestModels.PackageItemRMs;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Services
{
    public class AssignCargoToULDService : BaseService, IAssignCargoToULDService
    {
        private readonly IULDContainerCargoPositionService _uLDContainerCargoPositionService;

        public AssignCargoToULDService(
            IUnitOfWork unitOfWork,
            IMapper mapper, 
            IULDContainerCargoPositionService uLDContainerCargoPositionService)
            : base(unitOfWork, mapper)
        {
            _uLDContainerCargoPositionService = uLDContainerCargoPositionService;
        }

        public async Task<ServiceResponseCreateStatus> CreateAsync(ULDContainerCargoPositionDto package)
        {
            // if not exists CargoPositionId and ULDContainerId in ULDContainerCargoPosition

            await _uLDContainerCargoPositionService.CreateAsync(package);
            return new ServiceResponseCreateStatus() { StatusCode = Enums.ServiceResponseStatus.Success };
        }
    }
}
