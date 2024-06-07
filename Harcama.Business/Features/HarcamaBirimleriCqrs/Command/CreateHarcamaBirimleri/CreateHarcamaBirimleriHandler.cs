using AutoMapper;
using Harcama.Business.Abstract;
using Harcama.Entities.Concrete;
using MediatR;
using TS.Result;

namespace Harcama.Business.Features.HarcamaBirimleriCqrs.Command.CreateHarcamaBirimleri
{
    internal class CreateHarcamaBirimleriHandler(
        IHarcamaBirimleriServices harcamaBirimleriServices,
        IMapper mapper
        ) : IRequestHandler<CreateHarcamaBirimleri, Result<string>>
    {
        public async Task<Result<string>> Handle(CreateHarcamaBirimleri request, CancellationToken cancellationToken)
        {
            HarcamaBirimleri harcamaBirimleri = mapper.Map<HarcamaBirimleri>(request);
            await harcamaBirimleriServices.AddAsync(harcamaBirimleri);
            await harcamaBirimleriServices.SaveAsync();

            return "Ekleme Başarılı";
        }
    }
}
