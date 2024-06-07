using Harcama.Business.Abstract;
using Harcama.Entities.Concrete;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace Harcama.Business.Features.SirketCqrs.Query.GetAllSirket
{
    internal class GetAllSirketHandler(
        ISirketServices _sirketServices) : IRequestHandler<GetAllSirket, Result<List<Sirket>>>
    {
        public async Task<Result<List<Sirket>>> Handle(GetAllSirket request, CancellationToken cancellationToken)
        {
            List<Sirket> sirket = await _sirketServices.GetAll().ToListAsync();

            return sirket;
        }
    }
}
