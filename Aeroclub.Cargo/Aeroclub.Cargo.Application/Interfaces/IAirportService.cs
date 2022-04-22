using System.Collections.Generic;
using System.Threading.Tasks;
using Aeroclub.Cargo.Application.Models.Core;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IAirportService
    {
        Task<IReadOnlyList<BaseSelectListModel>> GetSelectListAsync();
    }
}