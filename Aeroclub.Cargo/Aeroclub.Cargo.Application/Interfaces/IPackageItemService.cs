using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.PackageItemQMs;
using Aeroclub.Cargo.Application.Models.Queries.PackageQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.PackageItemRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.PackageItemVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.PackageListItemVM;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IPackageItemService
    {
        Task<PackageItemCreateResponseM> CreateAsync(PackageItemCreateRM packageItem);
        Task<PackageItemMobileVM> GetAsync(PackageItemRefQM query);
        Task<PackageItemVM> GetAsync(PackageItemQM query);
        Task<ServiceResponseStatus> UpdateAsync(PackageItemUpdateRM packageItem);
        Task<Pagination<PackageListItemVM>> GetFilteredListAsync(PackageListQM query);

    }
}
