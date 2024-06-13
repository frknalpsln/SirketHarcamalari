using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace Harcama.Business.Features.HarcamaTalepleriCqrs.Command.CreateHarcamaTalepleri
{
    public record CreateHarcamaTalepleri(
     string Aciklama,
     string Gerekce,
     bool OnaylandiMi,
     DateTime Tarih,
     string Tutar,
     Guid UserId,
     Guid BirimId,
     Guid ProjeId) : IRequest<Result<string>>;
}
