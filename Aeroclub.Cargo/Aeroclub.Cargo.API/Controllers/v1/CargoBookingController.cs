﻿using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoBookingRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingSummaryVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingVMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
    [ApiVersion("1.0")]
    [Authorize]
    public class CargoBookingController : BaseApiController
    {
        private readonly IBookingManagerService _bookingManagerService;

        public CargoBookingController(IBookingManagerService bookingManagerService)
        {
            _bookingManagerService = bookingManagerService;
        }

        [HttpGet("GetFilteredList")]
        public async Task<ActionResult<Pagination<CargoBookingVM>>> GetFilteredListAsync([FromQuery] CargoBookingFilteredListQM query)
        {
            return Ok(await _bookingManagerService.GetBookingFilteredListAsync(query));
        } 
        
        [HttpGet("GetList")]
        public async Task<ActionResult<Pagination<CargoBookingVM>>> GetListAsync([FromQuery] FlightScheduleSectorBookingListQM query)
        {
            return Ok(await _bookingManagerService.GetBookingListAsync(query));
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

    }
}