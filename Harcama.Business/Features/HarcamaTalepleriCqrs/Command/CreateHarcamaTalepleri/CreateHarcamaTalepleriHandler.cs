using AutoMapper;
using Harcama.Business.Abstract;
using Harcama.Entities.Concrete;
using MediatR;
using TS.Result;

namespace Harcama.Business.Features.HarcamaTalepleriCqrs.Command.CreateHarcamaTalepleri
{
    internal class CreateHarcamaTalepleriHandler(
        IHarcamaTalepleriServices _harcamaTalepleriServices,
        IMapper _mapper) : IRequestHandler<CreateHarcamaTalepleri, Result<string>>
    {
        public async Task<Result<string>> Handle(CreateHarcamaTalepleri request, CancellationToken cancellationToken)
        {
            HarcamaTalepleri harcamaTalepleri = _mapper.Map<HarcamaTalepleri>(request);
            await _harcamaTalepleriServices.AddAsync(harcamaTalepleri);
            await _harcamaTalepleriServices.SaveAsync();

            return "Ekleme Başarılı";
        }
    }
}
