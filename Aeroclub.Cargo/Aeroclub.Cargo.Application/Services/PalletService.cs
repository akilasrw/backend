using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Queries.CargoPositionQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Application.Models.Queries.PalletManagementQMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoPositionVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class PalletService : BaseService, IPalletService
    {
        public PalletService(IUnitOfWork unitOfWork, IMapper mapper)
            :base(unitOfWork, mapper)
        {

        }

        public async Task<IReadOnlyList<CargoPositionVM>> GetFilteredPositionListAsync(PalletPositionSearchQM query)
        {
            var spec = new FlightScheduleSectorSpecification(new FlightScheduleSectorSearchQuery()
            {
                FlightDate = query.FlightDate,
                FlightNumber = query.FlightNumber,
                CargoPositionType = CargoPositionType.OnFloor
            });
            var entity = await _unitOfWork.Repository<FlightScheduleSector>().GetListWithSpecAsync(spec);
            var flightSector = entity.FirstOrDefault();
            if (flightSector == null)
                return  new List<CargoPositionVM>();

            var cargoPositionSpec = new CargoPositionSpecification(new CargoPositionListQM
            { AircraftLayoutId = flightSector.Aircraft.AircraftLayoutId, IncludeSeat = true, IncludeOverhead = true });

            var dtoList = await _unitOfWork.Repository<CargoPosition>().GetListWithSpecAsync(cargoPositionSpec);

            var cargoPositionList = _mapper.Map<IReadOnlyList<CargoPositionVM>>(dtoList);

            return cargoPositionList;
        }
    }
}
