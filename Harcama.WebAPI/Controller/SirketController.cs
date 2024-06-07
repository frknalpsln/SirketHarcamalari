using Harcama.Business.Features.HarcamaBirimleriCqrs.Command.CreateHarcamaBirimleri;
using Harcama.Business.Features.HarcamaBirimleriCqrs.Command.RemoveHarcamaBirimleri;
using Harcama.Business.Features.HarcamaBirimleriCqrs.Command.UpdateHarcamaBirimleri;
using Harcama.Business.Features.HarcamaBirimleriCqrs.Query.GetAllHarcamaBirimleri;
using Harcama.Business.Features.HarcamaBirimleriCqrs.Query.GetByIdHarcamaBirimleri;
using Harcama.Business.Features.SirketCqrs.Command.CreateSirket;
using Harcama.Business.Features.SirketCqrs.Command.RemoveSirket;
using Harcama.Business.Features.SirketCqrs.Command.UpdateSirket;
using Harcama.Business.Features.SirketCqrs.Query.GetAllSirket;
using Harcama.Business.Features.SirketCqrs.Query.GetByIdSirket;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Harcama.WebAPI.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SirketController(IMediator _mediator) : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult> Create(CreateSirket request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }


        [HttpPost]
        public async Task<IActionResult> Update(UpdateSirket request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
        [HttpPost]
        public async Task<IActionResult> Remove(RemoveSirket request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        public async Task<IActionResult> GetAll(GetAllSirket request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        public async Task<IActionResult> GetById(GetByIdSirket request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
    }
}
