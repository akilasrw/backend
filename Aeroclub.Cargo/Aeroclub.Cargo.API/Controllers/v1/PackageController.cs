using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.DeletePackageQM;
using Aeroclub.Cargo.Application.Models.Queries.ItemAuditQM;
using Aeroclub.Cargo.Application.Models.Queries.ItemsByDateQM;
using Aeroclub.Cargo.Application.Models.Queries.PackageItemQMs;
using Aeroclub.Cargo.Application.Models.Queries.PackageQMs;
using Aeroclub.Cargo.Application.Models.RequestModels;
using Aeroclub.Cargo.Application.Models.RequestModels.GetAWBbyUldAndFlightScheduleRM;
using Aeroclub.Cargo.Application.Models.RequestModels.GetPackagesByAWBandULDRM;
using Aeroclub.Cargo.Application.Models.RequestModels.PackageItemRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.ScanAppSixthStepRM;
using Aeroclub.Cargo.Application.Models.RequestModels.ScanAppThirdStepRM;
using Aeroclub.Cargo.Application.Models.ViewModels.PackageAuditVM;
using Aeroclub.Cargo.Application.Models.ViewModels.PackageItemVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.PackageListItemVM;
using Aeroclub.Cargo.Application.Models.ViewModels.ScanAppBookingCreateVM;
using Aeroclub.Cargo.Application.Services;
using Aeroclub.Cargo.Core.Entities;
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

        [HttpGet("AuditByBooking")]
        public async Task<ActionResult<ItemStatus>> GetPackageAuditByBooking([FromQuery] ItemAuditQM query)
        {
            return Ok(await _packageItemService.GetPackageItemAuditByBooking(query));
        }

        [HttpGet("PackageByDate")]
        public async Task<ActionResult<PackageAuditVM>> GetPackagesByDate([FromQuery] ItemsByDateQM query)
        {
            return Ok(await _packageItemService.GetPackagesByDate(query));
        }

        [HttpGet("PackageByAwbAndUld")]
        public async Task<IReadOnlyList<string>> GetPackagesByAwbAndUld([FromBody] GetPackageByAwbAndUldRM query)
        {
            return await _packageItemService.GetPackagesByAwbAndUld(query);
        }

        [HttpGet("AWBByFlightSheduleAndUld")]
        public async Task<HashSet<long>> GetAWBByFlightSheduleAndUld([FromQuery] GetAWBbyUldAndFlightScheduleRM query)
        {
            return await _packageItemService.GetAwbByUldAndFlightSchdule(query);
        }

        [HttpGet("GetFilteredAllList")]
        public async Task<ActionResult<PackageListItemVM>> GetFilteredAllListAsync([FromBody] PackageAllListQM query)
        {
            return Ok(await _packageItemService.GetFilteredAllListAsync(query));
        }

        [HttpGet("GetListByAwbAndStatus")]
        public async Task<ActionResult<PackageListItemVM>> GetListByAwbAndStatusAsync([FromBody] PackageListByAwbAndStatus query)
        {
            return Ok(await _packageItemService.GetListByAwbAndStatus(query));
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
                //_logger.LogError(ex, "An error occurred while updating the status.");
                return StatusCode(500, "An error occurred while processing your request.");
            }
        }

        [HttpPut("UpdateStatusByPackage")]
        public async Task<BaseResponse> UpdatePckageStatusAsync([FromBody] PackageItemStatusUpdateRM rm)
        {
            var response = new BaseResponse();
            try
            {
                var res = await _packageItemService.UpdatePackageStatusAsync(rm);

                if (res == ServiceResponseStatus.Failed)
                {
                    response.status = 400;
                    response.message = "Request Failed";
                    return response;
                }

                response.status = 200;
                response.message = "Request success";

                return response;
            }
            catch (Exception ex)
            {
                response.status = 400;
                response.message = "An error occurred while processing your request.";
                return response;
            }
        }

        [HttpPost("DeletePackage")]
        public async Task<ActionResult> DeleteItemById([FromQuery] DeletePackageQM qm)
        {
            var response = await _packageItemService.DeletePackage(qm.PackageId);
            if (response == ServiceResponseStatus.Success)
            {
                return NoContent();
            }
            return BadRequest("Cannot delete the package according to this ID");
            
        }


        [HttpPost("CreateTruckBookingAWBAndPackages")]
        public async Task<BaseResponse> CreateTruckBookingAWBAndPackages([FromBody] ScanAppBookingCreateVM rm)
        {
            var response = new BaseResponse();
            try
            {
                var res = await _packageItemService.CreateTruckBookingAWBAndPackages(rm);

                if (res == ServiceResponseStatus.Failed)
                {
                    response.status = 400;
                    response.message = "Request Failed";
                    return response;
                }

                response.status = 200;
                response.message = "Request success";

                return response;
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "An error occurred while processing the truck booking and packages creation.");
                response.status = 400;
                response.message = "An error occurred while processing your request.";
                return response;
            }
        }

        [HttpPost("UpdatePackageAndBookingStatusFromULD")]
        public async Task<BaseResponse> UpdatePackageAndBookingStatusFromULD([FromBody] PackageUpdateByULD rm)
        {
            var response = new BaseResponse();
            try
            {
                var res = await _packageItemService.UpdatePackageAndBookingStatusFromULD(rm);

                if (res == ServiceResponseStatus.Success)
                {
                    response.status = 200;
                    response.message = "Request success";

                    return response;
                }
               

                response.status = 400;
                response.message = "Request Failed";
                return response;
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "An error occurred while updating package and booking status from ULD.");
                response.status = 400;
                response.message = "An error occurred while processing your request.";
                return response;
            }
        }


        [HttpPost("CreateFlightScheduleULDandUpdateStatus")]
        public async Task<BaseResponse> CreateFlightScheduleULDandUpdateStatus([FromBody] ScanAppThirdStepRM rm)
        {
            var response = new BaseResponse();
            try
            {
                var res = await _packageItemService.CreateFlightScheduleULDandUpdateStatus(rm);

                if (res == ServiceResponseStatus.Success)
                {
                    response.status = 200;
                    response.message = "Request success";

                    return response;
                }

                response.status = 400;
                response.message = "Request Failed";
                return response;
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "An error occurred while creating flight schedule and updating status.");
                response.status = 400;
                response.message = "An error occurred while processing your request.";
                return response;
            }
        }


        [HttpPost("UpdateULDAndPackageStatus")]
        public async Task<BaseResponse> UpdateULDAndPackageStatus([FromBody] ScanAppSixthStepRM rm)
        {
            var response = new BaseResponse();
            try
            {
                var res = await _packageItemService.UpdateULDandPackageStatus(rm);

                if(res == ServiceResponseStatus.Success)
                {
                    response.status = 200;
                    response.message = "Request success";

                    return response;
                }
                else
                {
                    response.status = 400;
                    response.message = "Request Failed";
                    return response;
                }
                
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "An error occurred while updating ULD and package status.");
                response.status = 400;
                response.message = "An error occurred while processing your request.";
                return response;
            }
        }
    }
}
