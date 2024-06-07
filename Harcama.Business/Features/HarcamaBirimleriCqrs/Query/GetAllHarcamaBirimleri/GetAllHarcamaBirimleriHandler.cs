using Harcama.Business.Abstract;
using Harcama.Entities.Concrete;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace Harcama.Business.Features.HarcamaBirimleriCqrs.Query.GetAllHarcamaBirimleri
{
    internal class GetAllHarcamaBirimleriHandler(
        IHarcamaBirimleriServices _harcamaBirimleriServices) : IRequestHandler<GetAllHarcamaBirimleri, Result<List<HarcamaBirimleri>>>
    {
        public async Task<Result<List<HarcamaBirimleri>>> Handle(GetAllHarcamaBirimleri request, CancellationToken cancellationToken)
        {
            List<HarcamaBirimleri> harcamaBirimleri = await _harcamaBirimleriServices.GetAll().ToListAsync();

            return harcamaBirimleri;


        }
    }
}
