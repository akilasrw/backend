using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingQMs;
using Aeroclub.Cargo.Application.Models.Queries.ULDContainerCargoPositionQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoBookingRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleSectorPalletRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.PackageULDContainerRM;
using Aeroclub.Cargo.Application.Models.RequestModels.ULDContainerCargoPositionRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.ULDCargoBookingVMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
    [ApiVersion("1.0")]
    [Authorize]
    public class ULDCargoBookingController : BaseApiController
    {
        private readonly IULDCargoBookingManagerService _uldCargoBookingManagerService;
        public ULDCargoBookingController(IULDCargoBookingManagerService uldCargoBookingManagerService)
        {
            _uldCargoBookingManagerService = uldCargoBookingManagerService;
        }


        [HttpPost]
        public async Task<ActionResult> CreateAsync([FromBody] CargoBookingRM rm)
        {
            var res = await _uldCargoBookingManagerService.CreateAsync(rm);

            if (res == null) return BadRequest();

            if (res == Application.Enums.BookingServiceResponseStatus.NoSpace) return BadRequest("No available space for this.");
            if (res == Application.Enums.BookingServiceResponseStatus.Failed) return BadRequest("Save failed.");

            return CreatedAtAction(nameof(GetAsync), rm);
        }

        [HttpGet()]
        [ActionName(nameof(GetAsync))]
        public async Task<ActionResult<CargoBookingDetailVM>> GetAsync([FromQuery] CargoBookingDetailQM query)
        {
            if (query.Id == Guid.Empty) return BadRequest();

            var result = await _uldCargoBookingManagerService.GetBookingAsync(query);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateStatusAsync([FromBody] CargoBookingUpdateRM rm)
        {
            var res = await _uldCargoBookingManagerService.UpdateStatusAsync(rm);

            if (res == Application.Enums.BookingServiceResponseStatus.NoSpace) return BadRequest("No available space for this.");
            if (res == Application.Enums.BookingServiceResponseStatus.Failed) return BadRequest("Update failed.");

            return NoContent();
        }
        
        [HttpPut("StandByUpdate")]
        public async Task<IActionResult> StandByUpdateAsync([FromBody] CargoBookingStandbyUpdateRM rm)
        {
            var res = await _uldCargoBookingManagerService.StandByUpdateAsync(rm);

            if (res == Application.Enums.BookingServiceResponseStatus.NoSpace) return BadRequest("No available space for this.");
            if (res == Application.Enums.BookingServiceResponseStatus.ValidationError) return BadRequest("No flight schedule for this.");
            if (res == Application.Enums.BookingServiceResponseStatus.Failed) return BadRequest("Update failed.");

            return NoContent();
        }

        [HttpPost("AssignCargoToULD")]
        public async Task<IActionResult> AssignCargoToULDAsync(ULDContainerCargoPositionRM UldContainerCargoPosition)
        {
            return Ok(await _uldCargoBookingManagerService.AssginCargoToULDAsync(UldContainerCargoPosition));
        }
        
        [HttpPost("AddPalleteToFlight")]
        public async Task<IActionResult> AddPalleteToFlightAsync(FlightScheduleSectorPalletCreateRM flightScheduleSectorPallet)
        {
            return Ok(await _uldCargoBookingManagerService.AddPalleteToFlightAsync(flightScheduleSectorPallet));
        } 
        
        [HttpPost("SaveBookingAssigment")]
        public async Task<IActionResult> SaveBookingAssigmentAsync(BookingAssignmentRM bookingAssignment)
        {
            return Ok(await _uldCargoBookingManagerService.SaveBookingAssigmentAsync(bookingAssignment));
        }

        [HttpGet("GetULDBookingList")]
        public async Task<ActionResult<Pagination<ULDCargoBookingListVM>>> GetULDBookingListAsync([FromQuery] CargoPositionULDContainerListQM query)
        {
            return Ok(await _uldCargoBookingManagerService.GetULDBookingListAsync(query));
        }

    }
}
