using Harcama.Business.Features.HarcamaBirimleriCqrs.Command.CreateHarcamaBirimleri;
using Harcama.Business.Features.HarcamaBirimleriCqrs.Command.RemoveHarcamaBirimleri;
using Harcama.Business.Features.HarcamaBirimleriCqrs.Command.UpdateHarcamaBirimleri;
using Harcama.Business.Features.HarcamaBirimleriCqrs.Query.GetAllHarcamaBirimleri;
using Harcama.Business.Features.HarcamaBirimleriCqrs.Query.GetByIdHarcamaBirimleri;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Harcama.WebAPI.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HarcamaBirimleriController(IMediator _mediator) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(CreateHarcamaBirimleri request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }


        [HttpPost]
        public async Task<IActionResult> Update(UpdateHarcamaBirimleri request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
        [HttpPost]
        public async Task<IActionResult> Remove(RemoveHarcamaBirimleri request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        public async Task<IActionResult> GetAll(GetAllHarcamaBirimleri request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        public async Task<IActionResult> GetById(GetByIdHarcamaBirimleri request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
    }
}
