using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
    [ApiVersion("1.0")]
    [Authorize]
    public class ULDContainerController : BaseApiController
    {
        private readonly IULDContainerService _containerService;

        public ULDContainerController(IULDContainerService containerService)
        {
            _containerService = containerService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody]ULDContainerDto containerDto)
        {
            await _containerService.CreateAsync(containerDto);
            return Ok();
        }
    }
}
