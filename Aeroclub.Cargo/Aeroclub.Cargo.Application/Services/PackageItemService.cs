using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.PackageItemQMs;
using Aeroclub.Cargo.Application.Models.Queries.PackageQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.PackageItemRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.PackageListItemVM;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class PackageItemService : BaseService, IPackageItemService
    {
        public PackageItemService(IUnitOfWork unitOfWork, IMapper mapper) 
            : base(unitOfWork, mapper)
        {
        }

        public async Task<ServiceResponseStatus> CreateAsync(PackageItemRM packageItem)
        {
            var spec = new PackageItemSpecification(new PackageItemCountQM() { Year = DateTime.Now.Year, Month = DateTime.Now.Month });
            var packageCount = await _unitOfWork.Repository<PackageItem>().CountAsync(spec);

            ReferenceNumberSingletonService b1 = ReferenceNumberSingletonService.GetInstance(packageCount, CargoReferenceNumberType.Package);
            var package = _mapper.Map<PackageItem>(packageItem);
            package.PackageRefNumber = b1.GetNextRefNumber();

            await _unitOfWork.Repository<PackageItem>().CreateAsync(package);
            await _unitOfWork.SaveChangesAsync();

            return ServiceResponseStatus.Success;
        }

        public async Task<Pagination<PackageListItemVM>> GetFilteredListAsync(PackageListQM query)
        {
            var spec = new PackageItemSpecification(query);

            var packageList = await _unitOfWork.Repository<PackageItem>().GetListWithSpecAsync(spec);

            var countSpec = new PackageItemSpecification(query, true);

            var totalCount = await _unitOfWork.Repository<PackageItem>().CountAsync(countSpec);

            var dtoList = _mapper.Map<IReadOnlyList<PackageListItemVM>>(packageList);


            return new Pagination<PackageListItemVM>(query.PageIndex, query.PageSize, totalCount, dtoList);
        }

    }
}
