using System.Collections.Generic;
using System.Threading.Tasks;
using Aeroclub.Cargo.Application.Models.Core;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface ICountryService
    {
        Task<IReadOnlyList<BaseSelectListModel>> GetSelectListAsync();
    }
}