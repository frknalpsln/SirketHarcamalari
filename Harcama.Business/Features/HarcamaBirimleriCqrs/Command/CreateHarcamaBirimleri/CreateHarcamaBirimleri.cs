using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace Harcama.Business.Features.HarcamaBirimleriCqrs.Command.CreateHarcamaBirimleri
{
    public record CreateHarcamaBirimleri(
        string BirimAdi,
        string BirimKodu,
        string BirimYetkili,
        string BirimYetkiliTelefon
        ) : IRequest<Result<string>>;
}
