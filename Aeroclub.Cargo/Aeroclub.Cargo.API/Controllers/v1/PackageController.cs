using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.PackageItemQMs;
using Aeroclub.Cargo.Application.Models.Queries.PackageQMs;
using Aeroclub.Cargo.Application.Models.RequestModels;
using Aeroclub.Cargo.Application.Models.RequestModels.PackageItemRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.ScanAppSixthStepRM;
using Aeroclub.Cargo.Application.Models.RequestModels.ScanAppThirdStepRM;
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
        private readonly ILogger _logger;
        public PackageController(IPackageItemService packageItemService, ILogger logger)
        {
            _packageItemService = packageItemService;
            _logger = logger;
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
        public async Task<IActionResult> UpdateStatusAsync([FromBody] PackageItemUpdateStatusRM rm)
        {
            try
            {
                var res = await _packageItemService.UpdateStatusAsync(rm);

                if (res == ServiceResponseStatus.Failed)
                {
                    return BadRequest("Update failed.");
                }

                return Ok("Update successful.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while updating the status.");
                return StatusCode(500, "An error occurred while processing your request.");
            }
        }

        [HttpPut("UpdateStatusByPackage")]
        public async Task<IActionResult> UpdatePckageStatusAsync([FromBody] PackageItemStatusUpdateRM rm)
        {
            try
            {
                var res = await _packageItemService.UpdatePackageStatusAsync(rm);

                if (res == ServiceResponseStatus.Failed)
                {
                    return BadRequest("Update failed.");
                }

                return Ok("Update successful.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while updating the package status.");
                return StatusCode(500, "An error occurred while processing your request.");
            }
        }

        [HttpPost("CreateTruckBookingAWBAndPackages")]
        public async Task<IActionResult> CreateTruckBookingAWBAndPackages([FromBody] ScanAppBookingCreateVM rm)
        {
            try
            {
                var res = await _packageItemService.CreateTruckBookingAWBAndPackages(rm);

                if (res == ServiceResponseStatus.Failed)
                {
                    return BadRequest("Request failed.");
                }

                return Ok("Request successful.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while processing the truck booking and packages creation.");
                return StatusCode(500, "An error occurred while processing your request.");
            }
        }

        [HttpPost("UpdatePackageAndBookingStatusFromULD")]
        public async Task<IActionResult> UpdatePackageAndBookingStatusFromULD([FromBody] PackageUpdateByULD rm)
        {
            try
            {
                var res = await _packageItemService.UpdatePackageAndBookingStatusFromULD(rm);

                if (res == ServiceResponseStatus.Success)
                {
                    return Ok("Update successful.");
                }
                else if (res == ServiceResponseStatus.Failed)
                {
                    return BadRequest("Update failed.");
                }
             
                return StatusCode(500, "An unexpected error occurred while processing your request.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while updating package and booking status from ULD.");
                return StatusCode(500, "An error occurred while processing your request.");
            }
        }


        [HttpPost("CreateFlightScheduleULDandUpdateStatus")]
        public async Task<IActionResult> CreateFlightScheduleULDandUpdateStatus([FromBody] ScanAppThirdStepRM rm)
        {
            try
            {
                var res = await _packageItemService.CreateFlightScheduleULDandUpdateStatus(rm);

                if (res == ServiceResponseStatus.Success)
                {
                    return Ok("Request successful.");
                }

                return StatusCode(500, "An unexpected error occurred while processing your request.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while creating flight schedule and updating status.");
                return StatusCode(500, "An error occurred while processing your request.");
            }
        }


        [HttpPost("UpdateULDAndPackageStatus")]
        public async Task<IActionResult> UpdateULDAndPackageStatus([FromBody] ScanAppSixthStepRM rm)
        {
            try
            {
                var res = await _packageItemService.UpdateULDandPackageStatus(rm);

                if(res == ServiceResponseStatus.Success)
                {
                    return Ok("Request successful.");
                }else
                {
                    return BadRequest("Request failed");
                }
                
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while updating ULD and package status.");
                return StatusCode(500, "An error occurred while processing your request.");
            }
        }
    }
}
