using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingSummaryQMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingSummaryVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class CargoBookingSummaryService : BaseService, ICargoBookingSummaryService
    {
        public CargoBookingSummaryService(IUnitOfWork unitOfWork,
            IMapper mapper)
            :base(unitOfWork,mapper)
        {

        }

        public async Task<Pagination<CargoBookingSummaryVM>> GetFilteredListAsync(CargoBookingSummaryFilteredListQM query)
        {
            var spec = new FlightScheduleSpecification(query);
            var flightScheduleList = await _unitOfWork.Repository<FlightSchedule>().GetListWithSpecAsync(spec);

            var countSpec = new FlightScheduleSpecification(query, true);
            var totalCount = await _unitOfWork.Repository<FlightSchedule>().CountAsync(countSpec);

            var dtoList = _mapper.Map<IReadOnlyList<CargoBookingSummaryVM>>(flightScheduleList);

            return new Pagination<CargoBookingSummaryVM>(query.PageIndex, query.PageSize, totalCount, dtoList);
        }
    }
}
