﻿using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleManagementQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.AgentRateManagementRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleManagementRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleManagementVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleSectorVMs;
using Aeroclub.Cargo.Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
    [ApiVersion("1.0")]
    [Authorize]
    public class LinkAircraftToScheduleController : BaseApiController
    {
        private readonly ILinkAircraftToScheduleService _linkAircraftToScheduleService;

        public LinkAircraftToScheduleController(ILinkAircraftToScheduleService linkAircraftToScheduleService)
        {
            _linkAircraftToScheduleService = linkAircraftToScheduleService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] ScheduleAircraftRM query)
        {
            var res = await _linkAircraftToScheduleService.CreateAsync(query);
            if (res == Application.Enums.ServiceResponseStatus.ValidationError)
                return BadRequest(new { message = "Aircraft is not available. Please select another one." });
           
            return Ok(res);
        }

        [HttpPost("IsVerifiedBooking")]
        public async Task<IActionResult> IsVerifiedBookingAsync([FromBody] VerifyScheduleAicraftRM rm)
        {
            return Ok(await _linkAircraftToScheduleService.IsBookingsVerifiedAsync(rm));
        }
        
        [HttpPost("Upload"), DisableRequestSizeLimit]
        public async Task<IActionResult> UploadLIRFileRMAsync()
        {
            var formCollection = await Request.ReadFormAsync();
            Guid fsId = Guid.Parse(formCollection["FlightScheduleId"].ToString());
            var file = formCollection.Files.First();
            var res = await _linkAircraftToScheduleService.UploadLIRAsync(new UploadLIRFileRM() { File = file, FlightScheduleId= fsId });
            if (!res)
                return BadRequest(new { message = "Upload LIR File is failed." });
           
            return Ok();
        }


        [HttpGet("GetFilteredList")]
        public async Task<ActionResult<Pagination<FlightScheduleLinkAircraftVM>>> GetFilteredListAsync([FromQuery] FlightScheduleManagemenLinktFilteredListQM query)
        {
            return Ok(await _linkAircraftToScheduleService.GetLinkAircraftFilteredListAsync(query));
        }
    }
}
