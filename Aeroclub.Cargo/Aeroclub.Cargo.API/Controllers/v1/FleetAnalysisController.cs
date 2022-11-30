using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleQMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleVMs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
    public class FleetAnalysisController : BaseApiController
    {
        private readonly IFlightScheduleService _flightScheduleService;
        public FleetAnalysisController(IFlightScheduleService flightScheduleService)
        {
            _flightScheduleService = flightScheduleService;
        }


        [HttpGet("GetAircraftsIdleReport")]
        public async Task<ActionResult<IReadOnlyList<AircraftIdleReportVM>>> GetAircraftsIdleReportAsync([FromQuery]FlightScheduleReportQM query)
        {
            var res = await _flightScheduleService.GetAircraftsIdleReportAsync(query);
            return Ok(res);
        }
    }
}
