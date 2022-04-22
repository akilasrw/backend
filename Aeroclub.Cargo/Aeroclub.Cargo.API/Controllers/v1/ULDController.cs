using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
        public async Task<IActionResult> CreateAsync([FromBody] ULDDto uldDto)
        {
            await _uLDService.CreateAsync(uldDto);
            return Ok();
        }
    }
}
