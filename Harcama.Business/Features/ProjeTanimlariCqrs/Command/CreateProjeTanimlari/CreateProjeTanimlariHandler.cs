using AutoMapper;
using Harcama.Business.Abstract;
using Harcama.Entities.Concrete;
using MediatR;
using TS.Result;

namespace Harcama.Business.Features.ProjeTanimlariCqrs.Command.CreateProjeTanimlari
{
    internal class CreateProjeTanimlariHandler(
        IProjeTanimlariServices _projeTanimlariServices, IMapper _mapper) : IRequestHandler<CreateProjeTanimlari, Result<string>>
    {
        public async Task<Result<string>> Handle(CreateProjeTanimlari request, CancellationToken cancellationToken)
        {
            ProjeTanimlari projeTanimlari = _mapper.Map<ProjeTanimlari>(request);
            await _projeTanimlariServices.AddAsync(projeTanimlari);
            await _projeTanimlariServices.SaveAsync();

            return "Ekleme Başarılı";
        }
    }
}
