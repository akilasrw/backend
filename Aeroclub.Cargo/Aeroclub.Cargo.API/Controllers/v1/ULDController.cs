using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.RequestModels.ULDRMs;
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
    }
}
