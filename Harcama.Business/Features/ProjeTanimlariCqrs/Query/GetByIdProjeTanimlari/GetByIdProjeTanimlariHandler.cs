using Harcama.Business.Abstract;
using Harcama.Entities.Concrete;
using MediatR;
using TS.Result;

namespace Harcama.Business.Features.ProjeTanimlariCqrs.Query.GetByIdProjeTanimlari
{
    internal class GetByIdProjeTanimlariHandler(
        IProjeTanimlariServices _projeTanimlariServices) : IRequestHandler<GetByIdProjeTanimlari, Result<GetByIdProjeTanimlariResponse>>
    {
        public async Task<Result<GetByIdProjeTanimlariResponse>> Handle(GetByIdProjeTanimlari request, CancellationToken cancellationToken)
        {
            ProjeTanimlari projeTanimlari = await _projeTanimlariServices.GetById(request.Id);

            if (projeTanimlari is null)
            {
                return Result<GetByIdProjeTanimlariResponse>.Failure("Proje Bulunamadı");
            }

            return new GetByIdProjeTanimlariResponse(
                projeTanimlari.ProjeAdi,
                projeTanimlari.ProjeTanimi,
                projeTanimlari.ProjeBaslangicTarihi,
                projeTanimlari.ProjeYetkilisi,
                projeTanimlari.BirimId
             );
        }
    }
}
