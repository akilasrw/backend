using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoPositionRMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
    [ApiVersion("1.0")]
    [Authorize]
    public class ULDCargoPositionController : BaseApiController
    {
        private readonly IULDCargoPositionService _uLDCargoPositionService;
        public ULDCargoPositionController(IULDCargoPositionService uLDCargoPositionService)
        {
            this._uLDCargoPositionService = uLDCargoPositionService;
        }

        [HttpPost("Validate")]
        public async Task<ActionResult<ValidateResponse>> ValidateAsync([FromBody] ValidateCargoPositionRM rm)
        {
            var res = await _uLDCargoPositionService.ValidateCargoPositionAsync(rm);

            return Ok(res);
        }

    }
}
