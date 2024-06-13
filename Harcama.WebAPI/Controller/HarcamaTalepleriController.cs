using Harcama.Business.Features.HarcamaTalepleriCqrs.Command.CreateHarcamaTalepleri;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Harcama.WebAPI.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HarcamaTalepleriController(IMediator _mediator) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(CreateHarcamaTalepleri request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

        
        
    }
}
