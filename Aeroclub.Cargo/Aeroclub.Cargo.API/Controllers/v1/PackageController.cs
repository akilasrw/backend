using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.PackageItemQMs;
using Aeroclub.Cargo.Application.Models.Queries.PackageQMs;
using Aeroclub.Cargo.Application.Models.ViewModels.PackageItemVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.PackageListItemVM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
    [ApiVersion("1.0")]
    [Authorize]
    public class PackageController : BaseApiController
    {
        private readonly IPackageItemService _packageItemService;
        public PackageController(IPackageItemService packageItemService)
        {
            _packageItemService = packageItemService;
        }

        [HttpGet]
        public async Task<ActionResult<PackageItemMobileVM>> GetAsync([FromQuery] PackageItemRefQM query)
        {
            if (query.PackageRefNumber == null) return BadRequest();

            var result = await _packageItemService.GetAsync(query);

            if (result == null)
                return NotFound();

            return Ok(result);

        }

        [HttpGet("GetFilteredList")]
        public async Task<ActionResult<Pagination<PackageListItemVM>>> GetFilteredListAsync([FromQuery] PackageListQM query)
        {
            return Ok(await _packageItemService.GetFilteredListAsync(query));
        }




    }
}
