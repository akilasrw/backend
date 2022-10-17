using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Extensions;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.AirportQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.AirportRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AirportVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class AirportService :BaseService, IAirportService
    {
        private readonly ICountryService _countryService;

        public AirportService(IUnitOfWork unitOfWork, IMapper mapper, ICountryService countryService):
            base(unitOfWork,mapper)
        {
            _countryService = countryService;
        }

        public async Task<IReadOnlyList<BaseSelectListModel>> GetSelectListAsync()
        {
            var list = await _unitOfWork.Repository<Airport>().GetListAsync();
            return _mapper.Map<IReadOnlyList<BaseSelectListModel>>(list);
        }

        public async Task<Pagination<AirportVM>> GetFilteredListAsync(AirportListQM query)
        {
            var spec = new AirportSpecification(query);
            var airportList = await _unitOfWork.Repository<Airport>().GetListWithSpecAsync(spec);

            var countSpec = new AirportSpecification(query, true);
            var totalCount = await _unitOfWork.Repository<Airport>().CountAsync(countSpec);

            var dtoList = _mapper.Map<IReadOnlyList<AirportVM>>(airportList);

            return new Pagination<AirportVM>(query.PageIndex, query.PageSize, totalCount, dtoList);
        }

        public async Task<AirportVM> GetAsync(AirportQM query)
        {
            var spec = new AirportSpecification(query);
            var airport = await _unitOfWork.Repository<Airport>().GetEntityWithSpecAsync(spec);
            var airportVM = _mapper.Map<Airport, AirportVM>(airport);
            return airportVM;
        }

        public async Task<ServiceResponseCreateStatus> CreateAsync(AirportCreateRM dto)
        {
            var response = new ServiceResponseCreateStatus();

            var airportList = await _unitOfWork.Repository<Airport>().GetListWithSpecAsync(new AirportSpecification(new AirportValidationQM() { AirportCode = dto.Code }));

            if (airportList != null && airportList?.Count > 0)
            {
                response.StatusCode = ServiceResponseStatus.ValidationError;
                response.Message = "Airport is already available.";
                return response;
            }

            var isValidLat = await ValidAirportLatitudeAsync(dto.CountryId, dto.Lat);
            if (!isValidLat)
            {
                response.StatusCode = ServiceResponseStatus.ValidationError;
                response.Message = "Latitude is not valid.";
                return response;
            }

            var airport = _mapper.Map<Airport>(dto);
            await _unitOfWork.Repository<Airport>().CreateAsync(airport);
            await _unitOfWork.SaveChangesAsync();
            response.Id = airport.Id;
            response.StatusCode = ServiceResponseStatus.Success;
            return response;
        }

        public async Task<bool> ValidAirportLatitudeAsync(Guid countryId, double lat)
        {
            var country = await _countryService.GetAsync(countryId);
            var zone = TimeZoneExtension.GetBestTimeZoneByCountryId(country.CodeISO3166, lat);
            if(zone == null)
                return false;

            return true;
        }

        public async Task<bool> DeleteAsync(Guid Id)
        {
            var entity = await _unitOfWork.Repository<Airport>().GetByIdAsync(Id, false);
            entity.IsDeleted = true;
            return (await _unitOfWork.SaveChangesAsync() > 0);
        }

        public async Task<ServiceResponseStatus> UpdateAsync(AirportUpdateRM model)
        {
            var existingAirport = await _unitOfWork.Repository<Airport>().GetEntityWithSpecAsync(new AirportSpecification(new AirportValidationQM() { AirportCode = model.Code }));

            if (existingAirport != null && existingAirport.Id != model.Id)
            {
                return ServiceResponseStatus.ValidationError;
            }

            var entity = _mapper.Map<Airport>(model);
            _unitOfWork.Repository<Airport>().Update(entity);
            await _unitOfWork.SaveChangesAsync();
            _unitOfWork.Repository<Airport>().Detach(entity);
            return ServiceResponseStatus.Success;
        }
    }
}