using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.PackageItemQMs;
using Aeroclub.Cargo.Application.Models.Queries.PackageQMs;
using Aeroclub.Cargo.Application.Models.RequestModels;
using Aeroclub.Cargo.Application.Models.RequestModels.PackageItemRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.PackageItemVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.PackageListItemVM;
using Aeroclub.Cargo.Application.Models.ViewModels.ScanAppBookingCreateVM;
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

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody] PackageItemUpdateRM rm)
        {
            var res = await _packageItemService.UpdateAsync(rm);

            if (res == ServiceResponseStatus.Failed) return BadRequest("Update failed.");

            return NoContent();
        }

        [HttpPut("UpdateStatus")]
        public async Task<IActionResult> UpdateStatusAsync([FromBody] PackageItemUpdateStatusRM rm) // update Status
        {
            var res = await _packageItemService.UpdateStatusAsync(rm);

            if (res == ServiceResponseStatus.Failed) return BadRequest("Update failed.");

            return NoContent();
        }

        [HttpPut("UpdateStatusByPackage")]
        public async Task<IActionResult> UpdatePckageStatusAsync([FromBody] PackageItemStatusUpdateRM rm)
        {
            var res = await _packageItemService.UpdatePackageStatusAsync(rm);

            if (res == ServiceResponseStatus.Failed) return BadRequest("Update failed.");

            return NoContent();
        }

        [HttpPost("CreateTruckBookingAWBAndPackages")]
        public async Task<IActionResult> CreateTruckBookingAWBAndPackages([FromBody] ScanAppBookingCreateVM rm)
        {

            var res = await _packageItemService.CreateTruckBookingAWBAndPackages(rm);

            if (res == ServiceResponseStatus.Failed) return BadRequest("Request failed.");

            return NoContent();
        }

        [HttpPost("UpdatePackageAndBookingStatusFromULD")]
        public async Task<IActionResult> UpdatePackageAndBookingStatusFromULD([FromBody] PackageUpdateByULD rm) 
        {
            var res = await _packageItemService.UpdatePackageAndBookingStatusFromULD(rm);

            return NoContent();
        }
    }
}
