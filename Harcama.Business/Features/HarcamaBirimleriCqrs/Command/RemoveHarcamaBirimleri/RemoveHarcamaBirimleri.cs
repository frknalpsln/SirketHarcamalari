using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace Harcama.Business.Features.HarcamaBirimleriCqrs.Command.RemoveHarcamaBirimleri
{
    public record RemoveHarcamaBirimleri(string id) : IRequest<Result<string>>;
}
