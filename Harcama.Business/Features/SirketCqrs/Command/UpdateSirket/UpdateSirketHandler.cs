using AutoMapper;
using Harcama.Business.Abstract;
using Harcama.Entities.Concrete;
using MediatR;
using TS.Result;

namespace Harcama.Business.Features.SirketCqrs.Command.UpdateSirket
{
    internal class UpdateSirketHandler(ISirketServices _sirketServices,
        IMapper _mapper) : IRequestHandler<UpdateSirket, Result<string>>
    {
        public async Task<Result<string>> Handle(UpdateSirket request, CancellationToken cancellationToken)
        {
          Sirket sirket = await _sirketServices.GetById(request.Id);
            if(sirket is null) 
            {
                return Result<string>.Failure("Şirket Bulunamadı");
            }

            _mapper.Map(request, sirket);

            _sirketServices.Update(sirket);
            await _sirketServices.SaveAsync();

            return "Şirket Güncelleme İşlemi Başarılı";
        }
    }
}
