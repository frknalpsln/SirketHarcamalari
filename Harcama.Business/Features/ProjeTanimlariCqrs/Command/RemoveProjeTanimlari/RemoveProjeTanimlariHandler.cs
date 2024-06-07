using Harcama.Business.Abstract;
using Harcama.Entities.Concrete;
using MediatR;
using TS.Result;

namespace Harcama.Business.Features.ProjeTanimlariCqrs.Command.RemoveProjeTanimlari
{
    internal class RemoveProjeTanimlariHandler(
        IProjeTanimlariServices _projeTanimlariServices) : IRequestHandler<RemoveProjeTanimlari, Result<string>>
    {
        public async Task<Result<string>> Handle(RemoveProjeTanimlari request, CancellationToken cancellationToken)
        {

          ProjeTanimlari projeTanimlari = await  _projeTanimlariServices.GetById(request.Id);

            if (projeTanimlari is null)
            {
                return Result<string>.Failure("Proje Bulunamadı");
            }

            _projeTanimlariServices.Remove(projeTanimlari);
          await  _projeTanimlariServices.SaveAsync();

            return "Proje Silindi";
        }
    }
}
