using Aeroclub.Cargo.Application.Models.RequestModels.PackageItemRMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IAssignCargoToULDService
    {
        Task CreateAsync(Guid poisitonId, PackageItemCreateRM package);
    }
}
