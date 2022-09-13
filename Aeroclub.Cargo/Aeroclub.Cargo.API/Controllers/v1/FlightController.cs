using System.Collections.Generic;
using System.Threading.Tasks;
using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.FlightQMs;
using Aeroclub.Cargo.Application.Models.Queries.SectorQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.SectorVMs;
using Aeroclub.Cargo.Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
    [ApiVersion("1.0")]
    [Authorize]
    public class FlightController : BaseApiController
    {
        private readonly IFlightService _flightService;

        public FlightController(IFlightService flightService)
        {
            _flightService = flightService;
        }

        [HttpGet("getSelectList")]
        public async Task<ActionResult<IReadOnlyList<BaseSelectListModel>>> GetSelectListAsync()
        {
            return Ok(await _flightService.GetSelectListAsync());
        }

        [HttpGet()]
        [ActionName(nameof(GetAsync))]
        public async Task<ActionResult<FlightVM>> GetAsync([FromQuery]FlightQM query)
        {
            return Ok(await _flightService.GetAsync<FlightVM>(query));
        }


        [HttpGet("getDetail")]
        [ActionName(nameof(GetAsync))]
        public async Task<ActionResult<FlightVM>> GetDetailAsync([FromQuery] FlightDetailQM query)
        {
            return Ok(await _flightService.GetDetailAsync(query));
        }
        
        [HttpGet("getList")]
        public async Task<ActionResult<IReadOnlyList<FlightVM>>> GetListAsync([FromQuery] FlightListQM query)
        {
            return Ok(await _flightService.GetListAsync<FlightVM>(query));
        }

        [HttpGet("GetFilteredList")]
        public async Task<ActionResult<Pagination<FlightFilterVM>>> GetFilteredListAsync([FromQuery] FlightFilterListQM query)
        {
            return Ok(await _flightService.GetFilteredListAsync(query));
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] FlightCreateRM model)
        {

            var response = await _flightService.CreateAsync(model);
            if (response.StatusCode == ServiceResponseStatus.Success)
                return CreatedAtAction(nameof(GetAsync), new { id = response.Id }, model);

            return BadRequest("Flight creation fails.");
        }
    }
}