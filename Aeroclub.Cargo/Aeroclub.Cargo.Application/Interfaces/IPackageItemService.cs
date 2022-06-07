using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.PackageQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.PackageItemRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.PackageItemVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.PackageListItemVM;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IPackageItemService
    {
        Task<PackageItemCreateRM> CreateAsync(PackageItemRM packageItem);
        Task<PackageItemMobileVM> GetAsync(PackageItemQM query);
        Task<Pagination<PackageListItemVM>> GetFilteredListAsync(PackageListQM query);

    }
}
