using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightQMs;
using Aeroclub.Cargo.Application.Models.Queries.ULDContainerCargoPositionQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoBookingRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleSectorPalletRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.PackageULDContainerRM;
using Aeroclub.Cargo.Application.Models.RequestModels.ULDContainerCargoPositionRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.ULDCargoBookingVMs;
using Aeroclub.Cargo.Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
    [ApiVersion("1.0")]
    //[Authorize]
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
            if (res == Application.Enums.BookingServiceResponseStatus.NoAwb) return BadRequest("No available AWB in the Stack.");


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
        
        [HttpPost("AddPalleteToFlight")] // not use: need to be removed
        public async Task<IActionResult> AddPalleteToFlightAsync([FromBody]FlightScheduleSectorPalletCreateRM flightScheduleSectorPallet)
        {
            return Ok(await _uldCargoBookingManagerService.AddPalleteToFlightAsync(flightScheduleSectorPallet));
        }

        [HttpGet("GetPalletsByFlightScheduleId")]
        public async Task<IActionResult> GetPalletsByFlightScheduleId([FromQuery] FlightSheduleSectorPalletGetList filter)
        {
            return Ok(await _uldCargoBookingManagerService.GetPalleteFromFlights(filter));
        }
        
        [HttpPost("CreateRemovePalleteList")]
        public async Task<IActionResult> CreateRemovePalleteListAsync([FromBody] FlightScheduleSectorPalletCreateListRM flightScheduleSectorPallet)
        {
            return Ok(await _uldCargoBookingManagerService.CreateRemovePalleteListAsync(flightScheduleSectorPallet));
        }

        [HttpPost("RemoveAssignedPallet")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteAssignedPalletAsync(FlightScheduleSectorPalletCreateRM query)
        {
            var res = await _uldCargoBookingManagerService.DeleteAssignedPalletFromSchedule(query);

            if (res == ServiceResponseStatus.ValidationError)
            {
                return BadRequest("Can not be deleted. There is no pallet/ULD assigned for this scuedule.");
            }
            return NoContent();
        }

        [HttpPost("SaveBookingAssigment")]
        public async Task<IActionResult> SaveBookingAssigmentAsync(BookingAssignmentRM bookingAssignment)
        {
            return Ok(await _uldCargoBookingManagerService.SaveBookingAssigmentAsync(bookingAssignment));
        }

        [HttpPost("RemoveBookedAssigment")]
        public async Task<IActionResult> RemoveBookedAssigmentAsync(BookingAssignmentRM bookingAssignment)
        {
            return Ok(await _uldCargoBookingManagerService.RemoveBookedAssigmentAsync(bookingAssignment));
        }

        [HttpGet("GetULDBookingList")]
        public async Task<ActionResult<Pagination<ULDCargoBookingListVM>>> GetULDBookingListAsync([FromQuery] CargoPositionULDContainerListQM query)
        {
            return Ok(await _uldCargoBookingManagerService.GetULDBookingListAsync(query));
        }

    }
}
