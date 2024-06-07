using Harcama.Business.Abstract;
using Harcama.Entities.Concrete;
using MediatR;
using TS.Result;

namespace Harcama.Business.Features.SirketCqrs.Query.GetByIdSirket
{
    internal class GetByIdSirketHandler(ISirketServices _sirketServices) : IRequestHandler<GetByIdSirket, Result<GetByIdSirketResponse>>
    {
        public async Task<Result<GetByIdSirketResponse>> Handle(GetByIdSirket request, CancellationToken cancellationToken)
        {
           Sirket sirket = await _sirketServices.GetById(request.Id);

            if(sirket is null)
            {
                return Result<GetByIdSirketResponse>.Failure("Şirket Bulunamadı");
            }


            return new GetByIdSirketResponse(
                   sirket.SirketAdi,
                   sirket.SirketKodu,
                   sirket.TelefonNo,
                   sirket.Adres);
        }
    }
}
