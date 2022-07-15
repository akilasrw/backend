using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.CargoPositionQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoPositionRMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Common.Extentions;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;
using Microsoft.Extensions.Configuration;

namespace Aeroclub.Cargo.Application.Services
{
    public class ULDCargoPositionService : BaseService, IULDCargoPositionService
    {
        private readonly IFlightScheduleSectorService _flightScheduleSectorService;
        private readonly IConfiguration _configuration;


        public ULDCargoPositionService(IMapper mapper, IUnitOfWork unitOfWork, IFlightScheduleSectorService flightScheduleSectorService, IConfiguration configuration)
             : base(unitOfWork, mapper)
        {
            _flightScheduleSectorService = flightScheduleSectorService;
            _configuration = configuration;
        }

        public async Task<ServiceResponseCreateStatus> CreateAsync(ULDContainerCargoPositionDto ULDContainerCargoPositionDto)
        {
            var res = new ServiceResponseCreateStatus();

            var model = _mapper.Map<ULDContainerCargoPosition>(ULDContainerCargoPositionDto);

            var result = await _unitOfWork.Repository<ULDContainerCargoPosition>().CreateAsync(model);

            res.Id = result.Id;
            res.StatusCode = ServiceResponseStatus.Success;

            return res;
        }

        public async Task<ValidateResponse> ValidateCargoPositionAsync(ValidateCargoPositionRM rm)
        {

            var response = new ValidateResponse()
            {
                IsValid = false,
                ValidationMessage = "No available space for this."
            };

            var flightSector = await _flightScheduleSectorService.GetAsync(new FlightScheduleSectorQM() { Id = rm.FlightScheduleSectorId, IncludeLoadPlan = true });
            
            var cargoPositions = (CargoPositionType)rm.PackageItem.PackageContainerType;

            if (cargoPositions == CargoPositionType.OnFloor)
            {
                    var cargoPositionSpec = new CargoPositionSpecification(new CargoPositionListQM
                    { AircraftLayoutId = flightSector.AircraftLayoutId.Value });

                    var cargoPositionList = await _unitOfWork.Repository<CargoPosition>().GetListWithSpecAsync(cargoPositionSpec);

                    var position = cargoPositionList.First(x => x.CargoPositionType == cargoPositions);

                    return GetWeightValidationResponse(rm.PackageItem.Weight, position.MaxWeight, position.ZoneArea, rm.PackageItem.WeightUnitId);

            }
            
            return response;
        }


        private ValidateResponse GetWeightValidationResponse(double packageWeight, double maxWeight, ZoneArea zoneArea, Guid weightUnitId)
        {

            var kilogramWeightUnitId = _configuration["BaseUnit:BaseWeightUnitId"];
            if (weightUnitId != Guid.Empty && kilogramWeightUnitId.ToLower() != weightUnitId.ToString())
            {
                packageWeight = packageWeight.GramToKilogramConversion();
            }


            var isMaxWeightValid = true;
            string messagePrefix = "";

            if (packageWeight > maxWeight)
            {
                isMaxWeightValid = false;
                messagePrefix = "Position";

            }
            else if (zoneArea.CurrentWeight + packageWeight > zoneArea.MaxWeight)
            {
                isMaxWeightValid = false;
                messagePrefix = "Zone area";
            }
            else if (zoneArea.AircraftCabin.CurrentWeight + packageWeight > zoneArea.AircraftCabin.MaxWeight)
            {
                isMaxWeightValid = false;
                messagePrefix = "Aircraft cabin";

            }
            else if (zoneArea.AircraftCabin.AircraftDeck.CurrentWeight + packageWeight > zoneArea.AircraftCabin.AircraftDeck.MaxWeight)
            {
                isMaxWeightValid = false;
                messagePrefix = "Aircraft deck";
            }

            if (!isMaxWeightValid)
            {
                return new ValidateResponse()
                {
                    IsValid = false,
                    ValidationMessage = String.Format("{0} max weight({1}Kg) exceed.", messagePrefix, maxWeight)
                };

            }
            else
            {
                return new ValidateResponse() { IsValid = true };
            }

        }


    }
}
