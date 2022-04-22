

using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Queries.PackageContainerQMs;
using Aeroclub.Cargo.Application.Models.ViewModels.PackageContainerVMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
    [ApiVersion("1.0")]
    [Authorize]
    public class PackageContainerController : BaseApiController
    {
        private readonly IPackageContainerService _packageContainerService;

        public PackageContainerController(IPackageContainerService packageContainerService)
        {
            _packageContainerService = packageContainerService;
        }

        [HttpGet("GetList")]
        public async Task<ActionResult<IReadOnlyList<PackageContainerVM>>> GetListAsync([FromQuery] PackageContainerListQM query)
        {
            var res = await _packageContainerService.GetListAsync(query);
            return Ok(res);
        }

    }
}
