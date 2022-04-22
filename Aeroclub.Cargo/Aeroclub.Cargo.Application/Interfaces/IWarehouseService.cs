
using System;
using System.Threading.Tasks;
using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Queries.WarehouseQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.WarehouseRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.WarehouseVMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IWarehouseService
    {
        Task<ServiceResponseStatus> CreateAsync(WarehouseCreateRM model);
        Task<ServiceResponseStatus> UpdateAsync(WarehouseUpdateRM model);
        Task<WarehouseVM> GetAsync(WarehouseQM id);
        Task<bool> DeleteAsync(Guid id);


    }
}
