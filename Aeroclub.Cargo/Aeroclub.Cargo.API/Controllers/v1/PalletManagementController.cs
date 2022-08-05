using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Queries.PalletManagementQMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoPositionVMs;
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
        public async Task<ActionResult<IReadOnlyList<CargoPositionVM>>> GetFilteredPositionListAsync([FromQuery] PalletPositionSearchQM query)
        {
            return Ok(await _palletService.GetFilteredPositionListAsync(query));
        }

    }
}
