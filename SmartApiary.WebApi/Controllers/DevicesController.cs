using MediatR;
using Microsoft.AspNetCore.Mvc;
using SmartApiary.Application.Features.Devices.Queries;
using SmartApiary.WebApi.Extensions;

namespace SmartApiary.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevicesController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await mediator.Send(new GetDevicesQuery());

            if (result is null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Unexpected error.");
            }

            return result.ToActionResult();
        }
    }
}
