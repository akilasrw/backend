using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.CargoPositionQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Application.Models.Queries.PalletManagementQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.PalletManagementRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.ULDContainer;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoPositionVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Common.Extentions;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;
using Microsoft.Extensions.Configuration;

namespace Aeroclub.Cargo.Application.Services
{
    public class PalletService : BaseService, IPalletService
    {
        private readonly IULDMetaDataService _uLDMetaDataService;
        private readonly IULDService _uLDService;
        private readonly IULDContainerService _uLDContainerService;
        private readonly IConfiguration _configuration;
        public PalletService(IUnitOfWork unitOfWork, 
            IMapper mapper,
            IULDMetaDataService uLDMetaDataService, 
            IULDService uLDService, 
            IULDContainerService uLDContainerService, 
            IConfiguration configuration)
            :base(unitOfWork, mapper)
        {
            _uLDMetaDataService = uLDMetaDataService;
            _uLDService = uLDService;
            _uLDContainerService = uLDContainerService;
            _configuration = configuration;
        }

        public async Task<ServiceResponseCreateStatus> CreateAsync(PalletCreateRM dto)
        {
            var response = new ServiceResponseCreateStatus();

            using (var transaction = _unitOfWork.BeginTransaction())
            {
                try
                {
                    //Pallet volume conversion
                    var cmVolumeUnitId = _configuration["BaseUnit:BaseVolumeUnitId"];
                    if (dto.VolumeUnitId != Guid.Empty && cmVolumeUnitId.ToLower() != dto.VolumeUnitId.ToString())
                    {
                        var inchVolumeUnitId = _configuration["VolumeUnit:InchVolumeUnitId"];
                        var meterVolumeUnitId = _configuration["VolumeUnit:MeterVolumeUnitId"];

                        if (meterVolumeUnitId.ToLower() == dto.VolumeUnitId.ToString())
                        {
                            dto.Length = dto.Length.MeterToCmConversion();
                            dto.Width = dto.Width.MeterToCmConversion();
                            dto.Height = dto.Height.MeterToCmConversion();
                        }

                        if (inchVolumeUnitId.ToLower() == dto.VolumeUnitId.ToString())
                        {
                            dto.Length = dto.Length.InchToCmConversion();
                            dto.Width = dto.Width.InchToCmConversion();
                            dto.Height = dto.Height.InchToCmConversion();
                        }
                    }

                    //Pallet weight conversion
                    var kilogramWeightUnitId = _configuration["BaseUnit:BaseWeightUnitId"];
                    if (dto.WeightUnitId != Guid.Empty && kilogramWeightUnitId.ToLower() != dto.WeightUnitId.ToString())
                    {
                        dto.Weight = dto.Weight.GramToKilogramConversion();
                    }

                    var cargoPosition = await _unitOfWork.Repository<CargoPosition>().GetByIdAsync(id: dto.PositionId);

                    if (cargoPosition == null || cargoPosition.ULDContainers.Count <= 0)
                    {
                        transaction.Rollback();
                        response.StatusCode = ServiceResponseStatus.Failed;
                        return response;
                    }

                    // Save ULD meta data
                    var uldMetaDeta = await _uLDMetaDataService.CreateAsync(new ULDMetaDataDto()
                    {
                        Height = dto.Height,
                        Length = dto.Length,
                        Width = dto.Width,
                        Weight = dto.Weight,
                    });

                    if (uldMetaDeta == null)
                    {
                        transaction.Rollback();
                        response.StatusCode = ServiceResponseStatus.Failed;
                        return response;
                    }

                    // Save ULD
                    var uld = await _uLDService.CreateAsync(new ULDDto()
                    {
                        ULDType = ULDType.None,
                        SerialNumber = dto.SerialNumber,
                        ULDMetaDataId = uldMetaDeta.Id
                    });

                    if (uld == null)
                    {
                        transaction.Rollback();
                        response.StatusCode = ServiceResponseStatus.Failed;
                        return response;
                    }

                    foreach (var uldContainer in cargoPosition.ULDContainers)
                    {
                        await _uLDContainerService.UpdateAsync(new ULDContainerUpdateRM()
                        {
                            ULDId = uld.Id,
                            LoadPlanId = uldContainer.LoadPlanId,
                            ULDContainerType = uldContainer.ULDContainerType,
                            TotalWeight = uldContainer.TotalWeight,
                            Height = uldContainer.Height,
                            Width = uldContainer.Width,
                            Length = uldContainer.Length,
                        });

                    }
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
            response.StatusCode = ServiceResponseStatus.Success;

            return response;

        }

        public async Task<IReadOnlyList<CargoPositionVM>> GetFilteredPositionListAsync(PalletPositionSearchQM query)
        {
            var spec = new FlightScheduleSectorSpecification(new FlightScheduleSectorSearchQM()
            {
                FlightDate = query.FlightDate,
                FlightNumber = query.FlightNumber,
            });
            var entity = await _unitOfWork.Repository<FlightScheduleSector>().GetListWithSpecAsync(spec);
            var flightSector = entity.FirstOrDefault();
            if (flightSector == null)
                return  new List<CargoPositionVM>();

            var cargoPositionSpec = new CargoPositionSpecification(new CargoPositionListQM
            { AircraftLayoutId = flightSector.LoadPlan.AircraftLayoutId });

            var dtoList = await _unitOfWork.Repository<CargoPosition>().GetListWithSpecAsync(cargoPositionSpec);

            var cargoPositionList = _mapper.Map<IReadOnlyList<CargoPositionVM>>(dtoList);

            return cargoPositionList;
        }
    }
}
