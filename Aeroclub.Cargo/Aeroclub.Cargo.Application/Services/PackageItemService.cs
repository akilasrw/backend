using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.PackageItemQMs;
using Aeroclub.Cargo.Application.Models.Queries.PackageQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoBookingFlightScheduleSectorRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.PackageItemRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.PackageULDContainerRM;
using Aeroclub.Cargo.Application.Models.ViewModels.PackageItemVMs;
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
        private readonly ICargoBookingService _cargoBookingService;

        public PackageItemService(IUnitOfWork unitOfWork, IMapper mapper, ICargoBookingService cargoBookingService) 
            : base(unitOfWork, mapper)
        {
            _cargoBookingService = cargoBookingService;
        }

        public async Task<PackageItemCreateResponseM> CreateAsync(PackageItemCreateRM packageItem)
        {
            var spec = new PackageItemSpecification(new PackageItemCountQM() { Year = DateTime.Now.Year, Month = DateTime.Now.Month });
            var packageCount = await _unitOfWork.Repository<PackageItem>().CountAsync(spec);

            ReferenceNumberSingletonService b1 = ReferenceNumberSingletonService.GetInstance(packageCount, CargoReferenceNumberType.Package);
            var package = _mapper.Map<PackageItem>(packageItem);
            package.PackageRefNumber = b1.GetNextRefNumber();

            var createdPackage =await _unitOfWork.Repository<PackageItem>().CreateAsync(package);
            await _unitOfWork.SaveChangesAsync();

            var response = new PackageItemCreateResponseM();
            if (createdPackage != null)
            {
                response.StatusCode = ServiceResponseStatus.Success;
                response.Id = createdPackage.Id;
            }
            else
            {
                response.StatusCode = ServiceResponseStatus.Failed;
            }

            return response;
        }

        public async Task<PackageItemMobileVM> GetAsync(PackageItemRefQM query)
        {
            var spec = new PackageItemSpecification(query);
            var package = await _unitOfWork.Repository<PackageItem>().GetEntityWithSpecAsync(spec);
            return _mapper.Map<PackageItem, PackageItemMobileVM>(package);

        }

        public async Task<PackageItemVM> GetAsync(PackageItemQM query)
        {
            var package = await _unitOfWork.Repository<PackageItem>().GetByIdAsync(query.Id);
            return _mapper.Map<PackageItem, PackageItemVM>(package);
        }

        public async Task<ServiceResponseStatus> UpdateAsync(PackageItemUpdateRM rm)
        {
            var package = await _unitOfWork.Repository<PackageItem>().GetByIdAsync(rm.Id);
            if (package != null)
            {
                package.PackageItemStatus = rm.PackageItemStatus;
                _unitOfWork.Repository<PackageItem>().Update(package);
                await _unitOfWork.SaveChangesAsync();
                _unitOfWork.Repository<PackageItem>().Detach(package);

                await UpdateBookingStatusAsync(package.CargoBookingId); // update cargo booking status when all package items are received.

                return ServiceResponseStatus.Success;
            }
            else
            {
                return ServiceResponseStatus.Failed;
            }

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

        public async Task<ServiceResponseCreateStatus> PackageULDContainerCreate(PackageULDContainerRM rm)
        {
            var res = new ServiceResponseCreateStatus();
            var entity = _mapper.Map<PackageULDContainer>(rm);
            var response = await _unitOfWork.Repository<PackageULDContainer>().CreateAsync(entity);
            await _unitOfWork.SaveChangesAsync();
            if (response != null)
            {
                res.StatusCode = ServiceResponseStatus.Success;
                res.Id = response.Id;
            }
            else
            {
                res.StatusCode = ServiceResponseStatus.Failed;
            }
            return res;
        }

        async Task UpdateBookingStatusAsync(Guid BookingId)
        {
            var bookings = await _cargoBookingService.GetDetailAsync(new Models.Queries.CargoBookingQMs.CargoBookingQM { Id = BookingId, IsIncludePackageDetail = true });
            var acceptedCount = bookings.PackageItems.Count(x => x.PackageItemStatus == PackageItemStatus.Accepted);
            if (acceptedCount > 0 && acceptedCount == bookings.PackageItems.Count)
            {
                await _cargoBookingService.UpdateAsync(
                    new Models.RequestModels.CargoBookingRMs.CargoBookingUpdateRM 
                    { 
                        Id = BookingId,
                        BookingStatus = BookingStatus.Accepted 
                    });
            }
        }

    }
}
