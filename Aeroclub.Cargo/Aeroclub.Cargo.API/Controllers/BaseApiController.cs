using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
    }
}
