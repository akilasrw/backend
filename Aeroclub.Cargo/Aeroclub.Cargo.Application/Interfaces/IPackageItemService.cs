using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.ItemAuditQM;
using Aeroclub.Cargo.Application.Models.Queries.PackageItemQMs;
using Aeroclub.Cargo.Application.Models.Queries.PackageQMs;
using Aeroclub.Cargo.Application.Models.RequestModels;
using Aeroclub.Cargo.Application.Models.RequestModels.GetPackagesByAWBandULDRM;
using Aeroclub.Cargo.Application.Models.RequestModels.PackageItemRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.PackageULDContainerRM;
using Aeroclub.Cargo.Application.Models.RequestModels.ScanAppSixthStepRM;
using Aeroclub.Cargo.Application.Models.RequestModels.ScanAppThirdStepRM;
using Aeroclub.Cargo.Application.Models.ViewModels.PackageAuditVM;
using Aeroclub.Cargo.Application.Models.ViewModels.PackageItemVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.PackageListItemVM;
using Aeroclub.Cargo.Application.Models.ViewModels.ScanAppBookingCreateVM;
using Aeroclub.Cargo.Core.Entities;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IPackageItemService
    {
        Task<PackageItemCreateResponseM> CreateAsync(PackageItemCreateRM packageItem);
        Task<ServiceResponseStatus> DeletePackage(Guid packageId);
        Task<PackageItemMobileVM> GetAsync(PackageItemRefQM query);
        Task<PackageItemVM> GetAsync(PackageItemQM query);
        Task<ServiceResponseStatus> UpdateAsync(PackageItemUpdateRM packageItem);
        Task<Pagination<PackageListItemVM>> GetFilteredListAsync(PackageListQM query);
        Task<IReadOnlyList<PackageAuditVM>> GetPackageItemAuditByBooking(ItemAuditQM query);
        Task<IReadOnlyList<PackageListItemVM>> GetFilteredAllListAsync(PackageAllListQM query);
        Task<IReadOnlyList<String>> GetListByAwbAndStatus(PackageListByAwbAndStatus query);
        Task<IReadOnlyList<String>> GetPackagesByAwbAndUld(GetPackageByAwbAndUldRM query);
        Task<ServiceResponseCreateStatus> PackageULDContainerCreate(PackageULDContainerRM rm);
        Task<ServiceResponseStatus> UpdateStatusAsync(PackageItemUpdateStatusRM rm);

        Task<ServiceResponseStatus> UpdateULDandPackageStatus(ScanAppSixthStepRM rm);

        Task<ServiceResponseStatus> CreateTruckBookingAWBAndPackages(ScanAppBookingCreateVM rm);
        Task<ServiceResponseStatus> UpdatePackageStatusAsync(PackageItemStatusUpdateRM rm);

        Task<ServiceResponseStatus> UpdatePackageAndBookingStatusFromULD(PackageUpdateByULD rm);

        Task<ServiceResponseStatus> CreateFlightScheduleULDandUpdateStatus(ScanAppThirdStepRM rm);
    }
}
