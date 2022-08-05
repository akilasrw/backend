﻿

using Aeroclub.Cargo.Application.Models.Queries.PalletManagementQMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoPositionVMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IPalletService
    {
        Task<IReadOnlyList<CargoPositionVM>> GetFilteredPositionListAsync(PalletPositionSearchQM query);

    }
}