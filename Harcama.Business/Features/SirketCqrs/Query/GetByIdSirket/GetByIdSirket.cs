using Harcama.Business.Features.HarcamaBirimleriCqrs.Query.GetByIdHarcamaBirimleri;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace Harcama.Business.Features.SirketCqrs.Query.GetByIdSirket
{
    public record GetByIdSirket(
        string Id) : IRequest<Result<GetByIdSirketResponse>>;
}
