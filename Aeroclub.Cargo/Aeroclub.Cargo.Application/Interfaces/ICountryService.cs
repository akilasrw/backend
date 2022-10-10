using System.Collections.Generic;
using System.Threading.Tasks;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface ICountryService
    {
        Task<IReadOnlyList<BaseSelectListModel>> GetSelectListAsync();
        Task<CountryDto> GetAsync(Guid id);
    }
}