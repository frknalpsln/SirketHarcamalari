using Harcama.Business.Abstract;
using Harcama.Entities.Concrete;
using MediatR;
using TS.Result;

namespace Harcama.Business.Features.HarcamaBirimleriCqrs.Command.RemoveHarcamaBirimleri
{
    internal class RemoveHarcamaBirimleriHandler(
        IHarcamaBirimleriServices _harcamaBirimleriServices) : IRequestHandler<RemoveHarcamaBirimleri, Result<string>>
    {
        public async Task<Result<string>> Handle(RemoveHarcamaBirimleri request, CancellationToken cancellationToken)
        {
            HarcamaBirimleri harcamaBirimleri = await _harcamaBirimleriServices.GetById(request.id);
            if(harcamaBirimleri is null)
            {
                return Result<string>.Failure("Birim Bulunamadı");
            }
            _harcamaBirimleriServices.Remove(harcamaBirimleri);
          await  _harcamaBirimleriServices.SaveAsync();

            return "Birim Silindi";

        }
    }
}
