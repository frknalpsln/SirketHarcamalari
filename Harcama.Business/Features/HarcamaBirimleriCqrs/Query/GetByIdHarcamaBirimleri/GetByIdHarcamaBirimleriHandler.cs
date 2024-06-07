using Harcama.Business.Abstract;
using Harcama.Entities.Concrete;
using MediatR;
using TS.Result;

namespace Harcama.Business.Features.HarcamaBirimleriCqrs.Query.GetByIdHarcamaBirimleri
{
    internal class GetByIdHarcamaBirimleriHandler(
        IHarcamaBirimleriServices _harcamaBirimleriServices) : IRequestHandler<GetByIdHarcamaBirimleri, Result<GetByIdHarcamaBirimleriResponse>>
    {

        
        public async Task<Result<GetByIdHarcamaBirimleriResponse>> Handle(GetByIdHarcamaBirimleri request, CancellationToken cancellationToken)
        {
           HarcamaBirimleri harcamaBirimleri = await _harcamaBirimleriServices.GetById(request.Id);

            if(harcamaBirimleri is null)
            {
                return Result<GetByIdHarcamaBirimleriResponse>.Failure("Birim Bulunamadı");
            }

         return   new GetByIdHarcamaBirimleriResponse(
                harcamaBirimleri.BirimAdi,
                harcamaBirimleri.BirimYetkili,
                harcamaBirimleri.BirimYetkiliTelefon,
                harcamaBirimleri.BirimKodu);

            
             
        }
    }
}
