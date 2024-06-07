using Harcama.Business.Abstract;
using Harcama.Entities.Concrete;
using MediatR;
using TS.Result;

namespace Harcama.Business.Features.SirketCqrs.Command.RemoveSirket
{
    internal class RemoveSirketHandler(
        ISirketServices _sirketServices) : IRequestHandler<RemoveSirket, Result<string>>
    {
        public async Task<Result<string>> Handle(RemoveSirket request, CancellationToken cancellationToken)
        {
         Sirket sirket =await  _sirketServices.GetById(request.Id);

            if(sirket is null)
            {
                return Result<string>.Failure("Şirket Bulunamadı");
            }

            _sirketServices.Remove(sirket);
         await   _sirketServices.SaveAsync();

            return "Şirket Silindi";
        }
    }
}
