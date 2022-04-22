using System;
using System.Threading.Tasks;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Queries.WarehouseQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.WarehouseRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.WarehouseVMs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
    public class WarehouseController : BaseApiController
    {

        private readonly IWarehouseService _warehouseService;

        public WarehouseController(IWarehouseService warehouseService)
        {
            _warehouseService = warehouseService;
        }

        [HttpPost()]
        public async Task<IActionResult> Create([FromBody] WarehouseCreateRM model)
        {
            if (!ModelState.IsValid) return BadRequest("Some fields are missing");
            await _warehouseService.CreateAsync(model);
            return Ok();
        }

        [HttpPatch()]
        public async Task<IActionResult> Update([FromBody] WarehouseUpdateRM model)
        {
            if (!ModelState.IsValid) return BadRequest("Some fields are missing");
            await _warehouseService.UpdateAsync(model);
            return NoContent();
        }

        [HttpGet()]
        [ActionName(nameof(GetAsync))]
        public async Task<ActionResult<WarehouseVM>> GetAsync([FromQuery] WarehouseQM query)
        {
            if(query.Id == Guid.Empty) return BadRequest();
            var result = await _warehouseService.GetAsync(query);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteAsync(Guid id)
        {
            if (id == Guid.Empty) return BadRequest();

            return Ok(await _warehouseService.DeleteAsync(id));
        }

    }
}
