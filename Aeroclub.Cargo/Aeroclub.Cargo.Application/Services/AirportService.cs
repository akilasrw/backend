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
   

        public AirportService(IUnitOfWork unitOfWork, IMapper mapper):
            base(unitOfWork,mapper)
        {
           
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
            var airport = _mapper.Map<Airport>(dto);
            await _unitOfWork.Repository<Airport>().CreateAsync(airport);
            await _unitOfWork.SaveChangesAsync();
            response.Id = airport.Id;
            response.StatusCode = Enums.ServiceResponseStatus.Success;
            return response;
        }
    }
}