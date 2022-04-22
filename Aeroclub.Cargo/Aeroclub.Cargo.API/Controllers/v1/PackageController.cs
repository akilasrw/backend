using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.PackageQMs;
using Aeroclub.Cargo.Application.Models.ViewModels.PackageListItemVM;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
   
    public class PackageController : BaseApiController
    {
        private readonly IPackageItemService _packageItemService;
        public PackageController(IPackageItemService packageItemService)
        {
            _packageItemService = packageItemService;
        }

        [HttpGet("GetFilteredList")]
        public async Task<ActionResult<Pagination<PackageListItemVM>>> GetFilteredListAsync([FromQuery] PackageListQM query)
        {
            return Ok(await _packageItemService.GetFilteredListAsync(query));
        }


    }
}
