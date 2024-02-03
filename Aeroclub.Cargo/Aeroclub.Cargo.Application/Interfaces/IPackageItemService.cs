using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.PackageItemQMs;
using Aeroclub.Cargo.Application.Models.Queries.PackageQMs;
using Aeroclub.Cargo.Application.Models.RequestModels;
using Aeroclub.Cargo.Application.Models.RequestModels.PackageItemRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.PackageULDContainerRM;
using Aeroclub.Cargo.Application.Models.RequestModels.ScanAppSixthStepRM;
using Aeroclub.Cargo.Application.Models.RequestModels.ScanAppThirdStepRM;
using Aeroclub.Cargo.Application.Models.ViewModels.PackageItemVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.PackageListItemVM;
using Aeroclub.Cargo.Application.Models.ViewModels.ScanAppBookingCreateVM;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IPackageItemService
    {
        Task<PackageItemCreateResponseM> CreateAsync(PackageItemCreateRM packageItem);
        Task<PackageItemMobileVM> GetAsync(PackageItemRefQM query);
        Task<PackageItemVM> GetAsync(PackageItemQM query);
        Task<ServiceResponseStatus> UpdateAsync(PackageItemUpdateRM packageItem);
        Task<Pagination<PackageListItemVM>> GetFilteredListAsync(PackageListQM query);
        Task<IReadOnlyList<PackageListItemVM>> GetFilteredAllListAsync(PackageListQM query);
        Task<ServiceResponseCreateStatus> PackageULDContainerCreate(PackageULDContainerRM rm);
        Task<ServiceResponseStatus> UpdateStatusAsync(PackageItemUpdateStatusRM rm);

        Task<ServiceResponseStatus> UpdateULDandPackageStatus(ScanAppSixthStepRM rm);

        Task<ServiceResponseStatus> CreateTruckBookingAWBAndPackages(ScanAppBookingCreateVM rm);
        Task<ServiceResponseStatus> UpdatePackageStatusAsync(PackageItemStatusUpdateRM rm);

        Task<ServiceResponseStatus> UpdatePackageAndBookingStatusFromULD(PackageUpdateByULD rm);

        Task<ServiceResponseStatus> CreateFlightScheduleULDandUpdateStatus(ScanAppThirdStepRM rm);
    }
}
