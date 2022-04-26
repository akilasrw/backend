using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.UnitQMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IUnitService
    {
        Task<IReadOnlyList<BaseSelectListModel>> GetSelectListAsync(UnitQM query);
        Task<IReadOnlyList<UnitDto>> GetListAsync();

    }
}
