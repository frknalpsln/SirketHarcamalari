using Harcama.Business.Abstract;
using Harcama.Entities.Concrete;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace Harcama.Business.Features.ProjeTanimlariCqrs.Query.GetAllProjeTanimlari
{
    internal class GetAllProjeTanimlariHandler(
        IProjeTanimlariServices _projeTanimlariServices) : IRequestHandler<GetAllProjeTanimlari, Result<List<ProjeTanimlari>>>
    {
        public async Task<Result<List<ProjeTanimlari>>> Handle(GetAllProjeTanimlari request, CancellationToken cancellationToken)
        {
            List<ProjeTanimlari> projeTanimlari = await _projeTanimlariServices.GetAll().ToListAsync();

            return projeTanimlari;
        }
    }
}
