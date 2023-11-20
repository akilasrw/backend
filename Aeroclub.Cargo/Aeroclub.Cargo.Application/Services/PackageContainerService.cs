using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Queries.PackageContainerQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.PackageULDContainerRM;
using Aeroclub.Cargo.Application.Models.ViewModels.PackageContainerVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class PackageContainerService : BaseService, IPackageContainerService
    {
        public PackageContainerService(IUnitOfWork unitOfWork, IMapper mapper)
            :base(unitOfWork,mapper)
        {

        }
        public async Task<IReadOnlyList<PackageContainerVM>> GetListAsync(PackageContainerListQM query)
        {
            var spec  = new PackageContainerSpecification(query);
            var list = await _unitOfWork.Repository<PackageContainer>().GetListWithSpecAsync(spec);
            return _mapper.Map<IReadOnlyList<PackageContainerVM>>(list);
        }


    }
}
