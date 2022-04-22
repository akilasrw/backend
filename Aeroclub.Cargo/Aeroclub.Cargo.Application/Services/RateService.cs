using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.RateQMs;
using Aeroclub.Cargo.Application.Models.ViewModels.RateVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class RateService : BaseService, IRateService
    {
        public RateService(IUnitOfWork unitOfWork, IMapper mapper)
            : base(unitOfWork,mapper)
        {

        }

        public async Task<Pagination<RateVM>> GetFilteredListAsync(RateSectorQM query)
        {
            var packageSpec = new PackageContainerSectorSpecification(query);

            var packageList = await _unitOfWork.Repository<PackageContainerSector>().GetListWithSpecAsync(packageSpec);

            var mapedPackageList = _mapper.Map<IReadOnlyList<RateVM>>(packageList);

            var countSpec = new PackageContainerSectorSpecification(query, true);

            var totalCount = await _unitOfWork.Repository<PackageContainerSector>().CountAsync(countSpec);

            return new Pagination<RateVM>(query.PageIndex, query.PageSize, totalCount, mapedPackageList);

        }

    }
}
