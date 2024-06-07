using AutoMapper;
using Harcama.Business.Abstract;
using Harcama.Entities.Concrete;
using MediatR;
using TS.Result;

namespace Harcama.Business.Features.SirketCqrs.Command.CreateSirket
{
    internal class CreateSirketHandler(ISirketServices _sirketServices,
        IMapper _mapper) : IRequestHandler<CreateSirket, Result<string>>
    {
        public async Task<Result<string>> Handle(CreateSirket request, CancellationToken cancellationToken)
        {
            Sirket sirket = _mapper.Map<Sirket>(request);
            await _sirketServices.AddAsync(sirket);
            await _sirketServices.SaveAsync();

            return "Ekleme Başarılı";
        }
    }
}
