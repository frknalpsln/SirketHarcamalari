using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace Harcama.Business.Features.SirketCqrs.Command.UpdateSirket
{
    public record UpdateSirket(
     string Id,
     string SirketAdi,
     string SirketKodu,
     string Adres,
     string TelefonNo) : IRequest<Result<string>>;
}
