﻿using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoBookingRMs;
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
            
            if(res != Application.Enums.ServiceResponseStatus.Success) return BadRequest("Saved Failed.");
            
            return CreatedAtAction(nameof(GetAsync), rm);
        }

    }
}