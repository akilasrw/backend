using Aeroclub.Cargo.Application.Models.Queries.PackageContainerQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.PackageULDContainerRM;
using Aeroclub.Cargo.Application.Models.ViewModels.PackageContainerVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IPackageContainerService
    {
        Task<IReadOnlyList<PackageContainerVM>> GetListAsync(PackageContainerListQM query);
    }
}
