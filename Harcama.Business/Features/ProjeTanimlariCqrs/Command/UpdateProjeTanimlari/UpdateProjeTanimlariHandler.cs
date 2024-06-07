using AutoMapper;
using Harcama.Business.Abstract;
using Harcama.Entities.Concrete;
using MediatR;
using TS.Result;

namespace Harcama.Business.Features.ProjeTanimlariCqrs.Command.UpdateProjeTanimlari
{
    internal class UpdateProjeTanimlariHandler(
        IProjeTanimlariServices _projeTanimlariServices,
        IMapper _mapper) : IRequestHandler<UpdateProjeTanimlari, Result<string>>
    {
        public async Task<Result<string>> Handle(UpdateProjeTanimlari request, CancellationToken cancellationToken)
        {
           ProjeTanimlari projeTanimlari = await _projeTanimlariServices.GetById(request.Id);
            if(projeTanimlari is null) 
            {
                return Result<string>.Failure("Proje Bulunamadı");
            }

            _mapper.Map(request, projeTanimlari);

            _projeTanimlariServices.Update(projeTanimlari);
            await _projeTanimlariServices.SaveAsync();

            return "Proje Güncelleme Başarılı";
        }
    }
}
