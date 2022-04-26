

using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.UnitQMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
    [ApiVersion("1.0")]
    [Authorize]
    public class UnitController : BaseApiController
    {
        private readonly IUnitService  _unitService;

        public UnitController(IUnitService unitService)
        {
            _unitService = unitService;
        }

        [HttpGet("getSelectList")]
        public async Task<ActionResult<IReadOnlyList<BaseSelectListModel>>> GetSelectListAsync([FromQuery] UnitQM query)
        {
            return Ok(await _unitService.GetSelectListAsync(query));
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<UnitDto>>> GetListAsync()
        {
            return Ok(await _unitService.GetListAsync());
        }

    }
}
