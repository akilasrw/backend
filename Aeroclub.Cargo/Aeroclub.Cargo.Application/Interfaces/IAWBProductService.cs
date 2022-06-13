

using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.RequestModels.AirWayBillRMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IAWBProductService
    {
        Task<ServiceResponseCreateStatus> CreateAsync(AWBProductRM dto);
        Task<ServiceResponseStatus> UpdateAsync(AWBProductRM model);

    }
}
