using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.AirWayBillQMs;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoBookingRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.GetAirportsRM;
using Aeroclub.Cargo.Application.Models.RequestModels.GetShipmentsRM;
using Aeroclub.Cargo.Application.Models.ViewModels.BookingShipmentSummeryVM;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingSummaryVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.LocationsByAWBVM;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
    [ApiVersion("1.0")]
    [Authorize]
    public class CargoBookingController : BaseApiController
    {
        private readonly IBookingManagerService _bookingManagerService;
        private readonly UserManager<AppUser> _userManager;

        public CargoBookingController(IBookingManagerService bookingManagerService, UserManager<AppUser> userManager)
        {
            _bookingManagerService = bookingManagerService;
            _userManager = userManager;
        }

        [HttpGet("GetFilteredList")]
        public async Task<ActionResult<Pagination<CargoBookingVM>>> GetFilteredListAsync([FromQuery] CargoBookingFilteredListQM query)
        {
            return Ok(await _bookingManagerService.GetBookingFilteredListAsync(query));
        }

        [HttpGet("GetAirportsbyAWB")]
        public async Task<ActionResult<LocationsByAWBVM>> GetAirportsbyAWBAsync([FromBody] GetAirportsRM query)
        {
            return Ok(await _bookingManagerService.GetLocationsByAWBAsync(query));
        }

        [HttpGet("GetList")]
        public async Task<ActionResult<Pagination<CargoBookingVM>>> GetListAsync([FromQuery] FlightScheduleSectorBookingListQM query)
        {
            return Ok(await _bookingManagerService.GetBookingListAsync(query));
        }

        [HttpGet("GetAssignedCargoList")]
        public async Task<ActionResult<Pagination<CargoBookingVM>>> GetAssignedCargoList([FromQuery] AssignedCargoQM query)
        {
            return Ok(await _bookingManagerService.GetAssignedCargoList(query));
        }

        [HttpGet("GetMobileBooking")]
        public async Task<ActionResult<CargoBookingMobileVM>> GetMobileBookingAsync([FromQuery] FlightScheduleSectorMobileQM query)
        {
            return Ok(await _bookingManagerService.GetMobileBookingAsync(query));
        }

        [HttpGet("GetShipments")]
        public async Task<ActionResult<List<BookingShipmentSummeryVM>>> GetShipmentsByAWB([FromQuery] GetShipmentsRM rm) {


            if (HttpContext.Items.TryGetValue("User", out var user))

                if (user is AppUser userType)
                {
                    var roles = await _userManager.GetRolesAsync(userType);
                    var userId = userType.Id;
                    if (roles.Any((x) => x.Contains("Backoffice") || x.Contains("Super")))
                    {
                        var res = await _bookingManagerService.GetShipmentByAWB(rm, userId, true);
                        if(res != null)
                        {
                            return Ok(res);
                        }

                        return BadRequest("Booking not found");
                        
                    }
                    var result = await _bookingManagerService.GetShipmentByAWB(rm, userId);

                    if (result != null)
                    {
                        return Ok(result);
                    }

                    return BadRequest("Booking not found");
                }

            return null;




        }

        [HttpGet("GetStandByCargoList")]
        public async Task<ActionResult<Pagination<CargoBookingVM>>> GetStandByCargoListAsync([FromQuery] FlightScheduleSectorBookingListQM query)
        {
            return Ok(await _bookingManagerService.GetStandByCargoListAsync(query));
        }


        [HttpGet("GetBookingByPackageStatus/{type}")]
        public async Task<ActionResult<Pagination<CargoBookingVM>>> GetBookingByPackageStatus(PackageItemStatus type)
        {
            return Ok(await _bookingManagerService.GetBookingByPackageStatus(type));
        }

        [HttpGet("GetVerifyBookingList")]
        public async Task<ActionResult<Pagination<CargoBookingVM>>> GetVerifyBookingListAsync([FromQuery] FlightScheduleSectorVerifyBookingListQM query)
        {
            return Ok(await _bookingManagerService.GetVerifyBookingListAsync(query));
        }
        
        [HttpGet("GetFreighterBookingList")]
        public async Task<ActionResult<Pagination<CargoBookingVM>>> GetFreighterBookingListAsync([FromQuery] FlightScheduleSectorBookingListQM query)
        {
            return Ok(await _bookingManagerService.GetFreighterBookingListAsync(query));
        }

        [HttpGet()]
        [ActionName(nameof(GetAsync))]
        public async Task<ActionResult<CargoBookingDetailVM>> GetAsync([FromQuery] CargoBookingDetailQM query)
        {
            if (query.Id == Guid.Empty) return BadRequest();
              
            var result = await _bookingManagerService.GetBookingAsync(query);

            if (result == null)
                return NotFound();

            return Ok(result);
        }
        
        [HttpGet("GetDetail")]
        public async Task<ActionResult<CargoBookingDetailVM>> GetDetailAsync([FromQuery] CargoBookingQM query)
        {
            if (query.Id == Guid.Empty) return BadRequest();
              
            var result = await _bookingManagerService.GetDetailAsync(query);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> CreateAsync([FromBody] CargoBookingRM rm)
        {
            var res = await _bookingManagerService.CreateAsync(rm);
            
            if (res == null) return BadRequest();
            
            if(res == Application.Enums.BookingServiceResponseStatus.Failed) return BadRequest("Save failed.");
            if(res == Application.Enums.BookingServiceResponseStatus.NoSpace) return BadRequest("No available space for this.");
            
            return CreatedAtAction(nameof(GetAsync), rm);
        }

        [HttpGet("GetSummary")]
        public async Task<ActionResult<CargoBookingSummaryDetailVM>> GetSummaryAsync([FromQuery] BookingSummaryQuery query)
        {
            return Ok(await _bookingManagerService.GetBookingSummaryAsync(query));
        }

        [HttpGet("GetSeatSummary")]
        public async Task<ActionResult<IEnumerable<SeatDto>>> GetSeatSummaryAsync([FromQuery] FlightScheduleSectorSearchQuery query)
        {
            var result = await _bookingManagerService.GetSeatBookingSummaryLayoutAsync(query);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody] CargoBookingUpdateRM rm)
        {
            var res = await _bookingManagerService.UpdateAsync(rm);

            if (res == Application.Enums.BookingServiceResponseStatus.NoSpace) return BadRequest("No available space for this.");
            if (res == Application.Enums.BookingServiceResponseStatus.Failed) return BadRequest("Update failed.");

            return NoContent();
        }

        [HttpPut("UpdateStandByStatus")]
        public async Task<IActionResult> UpdateStandByStatusAsync([FromBody] CargoBookingStatusUpdateListRM rm)
        {
            var res = await _bookingManagerService.UpdateStandByStatusAsync(rm);

            if (res == Application.Enums.ServiceResponseStatus.Failed) return BadRequest("Update failed.");

            return NoContent();
        }

        [HttpPut("UpdateDeleteCargo")]
        public async Task<IActionResult> UpdateDeleteCargoAsync([FromBody] IEnumerable<CargoBookingUpdateRM> list)
        {
            var res = await _bookingManagerService.UpdateDeleteListAsync(list);

            if (res == Application.Enums.ServiceResponseStatus.Failed) return BadRequest("Update failed.");

            return NoContent();
        }

    }
}