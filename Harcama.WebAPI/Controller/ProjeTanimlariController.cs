using Harcama.Business.Features.HarcamaBirimleriCqrs.Command.CreateHarcamaBirimleri;
using Harcama.Business.Features.HarcamaBirimleriCqrs.Command.RemoveHarcamaBirimleri;
using Harcama.Business.Features.HarcamaBirimleriCqrs.Command.UpdateHarcamaBirimleri;
using Harcama.Business.Features.HarcamaBirimleriCqrs.Query.GetAllHarcamaBirimleri;
using Harcama.Business.Features.HarcamaBirimleriCqrs.Query.GetByIdHarcamaBirimleri;
using Harcama.Business.Features.ProjeTanimlariCqrs.Command.CreateProjeTanimlari;
using Harcama.Business.Features.ProjeTanimlariCqrs.Command.RemoveProjeTanimlari;
using Harcama.Business.Features.ProjeTanimlariCqrs.Command.UpdateProjeTanimlari;
using Harcama.Business.Features.ProjeTanimlariCqrs.Query.GetAllProjeTanimlari;
using Harcama.Business.Features.ProjeTanimlariCqrs.Query.GetByIdProjeTanimlari;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Harcama.WebAPI.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProjeTanimlariController(IMediator _mediator) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(CreateProjeTanimlari request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }


        [HttpPost]
        public async Task<IActionResult> Update(UpdateProjeTanimlari request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
        [HttpPost]
        public async Task<IActionResult> Remove(RemoveProjeTanimlari request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        public async Task<IActionResult> GetAll(GetAllProjeTanimlari request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        public async Task<IActionResult> GetById(GetByIdProjeTanimlari request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
    }
}
