using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace Harcama.Business.Features.HarcamaBirimleriCqrs.Query.GetByIdHarcamaBirimleri
{
    public record GetByIdHarcamaBirimleri(
        string Id) : IRequest<Result<GetByIdHarcamaBirimleriResponse>>;
}
