using Aeroclub.Cargo.Application.Models.RequestModels.PackageItemRMs;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface ICargoPositionService
    {
        Task<Tuple<CargoPosition, Guid?>> GetMatchingCargoPosition(PackageItemRM packageItem, Guid aircraftLayoutId, CargoPositionType cargoPositionType);
    }
}
