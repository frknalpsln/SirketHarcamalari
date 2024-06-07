using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace Harcama.Business.Features.HarcamaBirimleriCqrs.Command.UpdateHarcamaBirimleri
{
    public record UpdateHarcamaBirimleri(
        string Id,
        string BirimAdi,
        string BirimKodu,
        string BirimYetkili,
        string BirimYetkiliTelefon) : IRequest<Result<string>>;
}
