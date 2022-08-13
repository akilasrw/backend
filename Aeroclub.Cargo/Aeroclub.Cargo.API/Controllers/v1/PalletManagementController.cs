using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Queries.PalletManagementQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.PalletManagementRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoPositionVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.PalletVMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
    [ApiVersion("1.0")]
    [Authorize]
    public class PalletManagementController : BaseApiController
    {
        private readonly IPalletService _palletService;
        public PalletManagementController(IPalletService palletService)
        {
            _palletService = palletService;

        }


        [HttpGet("GetFilteredPositionList")]
        public async Task<ActionResult<IReadOnlyList<PalletDetailVM>>> GetFilteredPositionListAsync([FromQuery] PalletPositionSearchQM query)
        {
            return Ok(await _palletService.GetFilteredPositionListAsync(query));
        }

        [HttpPost()]
        public async Task<IActionResult> CreateAsync([FromBody] PalletCreateRM dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var response = await _palletService.CreateAsync(dto);

            if (response.StatusCode == ServiceResponseStatus.ValidationError)
                return BadRequest("Unable to add pallet.");

            if (response.StatusCode == ServiceResponseStatus.Success)
                return Ok(new { message = "Pallet added successfully." });
         
            return BadRequest("Pallet adding fails.");

        }

    }
}
