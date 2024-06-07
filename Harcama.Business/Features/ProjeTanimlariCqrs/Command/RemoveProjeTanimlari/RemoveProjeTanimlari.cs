using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace Harcama.Business.Features.ProjeTanimlariCqrs.Command.RemoveProjeTanimlari
{
    public record RemoveProjeTanimlari(
        string Id) : IRequest<Result<string>>;
}
