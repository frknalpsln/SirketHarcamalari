using Harcama.Entities.Concrete;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace Harcama.Business.Features.ProjeTanimlariCqrs.Command.UpdateProjeTanimlari
{
    public record UpdateProjeTanimlari(
     string Id,
     string ProjeAdi,
     string ProjeTanimi,
     DateTime ProjeBaslangic,
     string ProjeYetkilisi,
     Sirket Sirket,
     HarcamaBirimleri Birim) : IRequest<Result<string>>;
}
