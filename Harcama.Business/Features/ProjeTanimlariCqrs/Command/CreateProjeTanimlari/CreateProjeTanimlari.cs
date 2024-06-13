using Harcama.Entities.Concrete;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace Harcama.Business.Features.ProjeTanimlariCqrs.Command.CreateProjeTanimlari
{
    public record CreateProjeTanimlari(
       
     string ProjeAdi,
     string ProjeTanimi,
     DateTime ProjeBaslangicTarihi,
     string ProjeYetkilisi,
     Guid BirimId 
             
       ) : IRequest<Result<string>>;
}
