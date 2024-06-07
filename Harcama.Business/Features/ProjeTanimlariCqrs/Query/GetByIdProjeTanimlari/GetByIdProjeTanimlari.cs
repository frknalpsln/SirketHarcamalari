using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace Harcama.Business.Features.ProjeTanimlariCqrs.Query.GetByIdProjeTanimlari
{
    public record GetByIdProjeTanimlari(
        string Id) : IRequest<Result<GetByIdProjeTanimlariResponse>>;
}
