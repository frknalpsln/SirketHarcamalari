using AutoMapper;
using Harcama.Business.Abstract;
using Harcama.Entities.Concrete;
using MediatR;
using TS.Result;

namespace Harcama.Business.Features.HarcamaBirimleriCqrs.Command.UpdateHarcamaBirimleri
{
    internal class UpdateHarcamaBirimleriHandler(IHarcamaBirimleriServices _harcamaBirimleriServices,
        IMapper _mapper) : IRequestHandler<UpdateHarcamaBirimleri, Result<string>>
    {
        public async Task<Result<string>> Handle(UpdateHarcamaBirimleri request, CancellationToken cancellationToken)
        {
            HarcamaBirimleri harcamaBirimleri = await _harcamaBirimleriServices.GetById(request.Id);

            if (harcamaBirimleri is null)
            {
                return Result<string>.Failure("Birim Bulunamadı...");
            }


            _mapper.Map(request, harcamaBirimleri);

            _harcamaBirimleriServices.Update(harcamaBirimleri);
            await _harcamaBirimleriServices.SaveAsync();

            return "Birim Güncelleme İşlemi Başarılı";
        }
    }
}
