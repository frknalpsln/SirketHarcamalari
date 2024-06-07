using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace Harcama.Business.Features.SirketCqrs.Command.RemoveSirket
{
    public record RemoveSirket(
        string Id) : IRequest<Result<string>>;
}
