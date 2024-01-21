using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.AirportQMs;
using Aeroclub.Cargo.Application.Models.Queries.ULDQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.ULDByFlightScheduleRM;
using Aeroclub.Cargo.Application.Models.RequestModels.ULDRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.ULDVMs;
using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
    [ApiVersion("1.0")]
    [Authorize]
    public class ULDController : BaseApiController
    {
        private readonly IULDService _uLDService;

        public ULDController(IULDService uLDService)
        {
            _uLDService = uLDService;
        }

        [HttpGet("GetFilteredList")]
        public async Task<ActionResult<Pagination<ULDFilteredListVM>>> GetFilteredListAsync([FromQuery] ULDListQM query)
        {
            return Ok(await _uLDService.GetFilteredListAsync(query));
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] ULDCreateRM uldDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var response = await _uLDService.CreateAsync(uldDto);

            if (response.StatusCode == ServiceResponseStatus.ValidationError)
                return BadRequest(response.Message);

            if (response.StatusCode == ServiceResponseStatus.Success)
                return Ok(new { message = "ULD created successfully." });

            return BadRequest("ULD creation fails.");
        }

        [HttpPut()]
        public async Task<IActionResult> UpdateAsync([FromBody] ULDUpdateRM model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var response = await _uLDService.UpdateAsync(model);
            if (response == ServiceResponseStatus.Failed)
            {
                return BadRequest("ULD update is failed.");
            }
            return NoContent();
        }


        [HttpGet("ULDByFlightAndDate")]
        public async Task<IActionResult> GetULDByDateAndFlightSchedule([FromBody] ULDByFlightScheduleRM rm)
        {
            var ulds = await _uLDService.GetULDByFlightSchedule(rm);

            return Ok(ulds) ;

        }

    }
}
