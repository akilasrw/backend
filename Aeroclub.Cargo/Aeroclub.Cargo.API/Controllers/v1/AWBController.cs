﻿using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Queries.AirWayBillQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.AirWayBillRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AirWayBillVMs;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
   
    public class AWBController : ControllerBase
    {
        private readonly IAWBService _awbService;
        public AWBController(IAWBService awbService)
        {
            this._awbService = awbService;

        }

        [HttpPost()]
        public async Task<IActionResult> CreateAsync([FromBody] AWBCreateRM dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var response = await _awbService.CreateAsync(dto);

            if (response.StatusCode == Application.Enums.ServiceResponseStatus.Success)
                return CreatedAtAction(nameof(GetAsync), new { id = response.Id }, dto);

            return BadRequest("AWB creation fail");
        }

        [HttpGet()]
        [ActionName(nameof(GetAsync))]
        public async Task<ActionResult<AWBInformationVM>> GetAsync([FromQuery] AirWayBillQM query)
        {
            if (query.Id == Guid.Empty) return BadRequest();

            var result = await _awbService.GetAsync(query);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

    }
}
