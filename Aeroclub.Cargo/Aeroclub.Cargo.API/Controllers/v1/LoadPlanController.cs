using System.Threading.Tasks;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.FlightQMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightVMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
    [ApiVersion("1.0")]
    [Authorize]
    public class LoadPlanController : BaseApiController
    {
        private readonly ILoadPlanService _loadPlanService;

        public LoadPlanController(ILoadPlanService loadPlanService)
        {
            _loadPlanService = loadPlanService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] LoadPlanDto dto)
        {
            await _loadPlanService.CreateAsync(dto);
            return Ok();
        }
    }
}