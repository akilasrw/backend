using Aeroclub.Cargo.Application.Interfaces;
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

        public async Task CreateAsync(Guid poisitonId, PackageItemCreateRM package)
        {
            // if not exists CargoPositionId and ULDContainerId in ULDContainerCargoPosition
            await _uLDContainerCargoPositionService.CreateAsync(new ULDContainerCargoPositionDto()
            {
                CargoPositionId = poisitonId,
                ULDContainerId = package.ULDContainerId.Value,
            });
        }

        //var cargoPosition = await _unitOfWork.Repository<CargoPosition>().GetByIdAsync(id: dto.PositionId);

        //if (cargoPosition == null)
        //{
        //    transaction.Rollback();
        //    response.StatusCode = ServiceResponseStatus.Failed;
        //    return response;
        //}



        //var positionContainers = await _ULDContainerCargoPositionService.GetListAsync(new ULDCOntainerCargoPositionQM()
        //{
        //    IsIncludeULDContainer = true,
        //    CargoPositionId = cargoPosition.Id
        //});

        // assgined boxes to Pallet. 
        //if (positionContainers != null && positionContainers.Count > 0)
        //{
        //    foreach (var positionContainer in positionContainers)
        //    {
        //        await _uLDContainerService.UpdateULDIdAsync(new ULDContainerUpdateRM()
        //        {
        //            Id = positionContainer.ULDContainer.Id,
        //            ULDId = uld.Id,
        //        });

        //    }
        //}
        //else
        //{
        //    transaction.Rollback();
        //    response.StatusCode = ServiceResponseStatus.ValidationError;
        //    return response;
        //}


        // Update ULDContainer Cargo Position
        //await _uLDContainerCargoPositionService.CreateAsync(new ULDContainerCargoPositionDto()
        //{
        //    CargoPositionId = matchedCargoPosition.Id,
        //    ULDContainerId = uldContainer.Id
        //});

        //// Update Current Weights
        //await UpdateCurrentWeightAsyncs(matchedCargoPosition.Id,package.Weight);

        //// Update Current Volume
        //await UpdateCurrentVolumeAsyncs(matchedCargoPosition.Id, package.Volume);



        //CargoPosition matchedCargoPosition = null;
        //if (package.PackageContainerType == PackageContainerType.OnFloor)
        //    matchedCargoPosition = await _uldcgoPositionService.GetMatchingCargoPositionAsync(package, flightSector.AircraftLayoutId.Value, (CargoPositionType)package.PackageContainerType);

        //if (matchedCargoPosition == null)
        //{
        //    transaction.Rollback();
        //    return BookingServiceResponseStatus.NoSpace;
        //}
    }
}
