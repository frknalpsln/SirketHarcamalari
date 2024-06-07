using Harcama.Entities.Concrete;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace Harcama.Business.Features.ProjeTanimlariCqrs.Query.GetAllProjeTanimlari
{
    public record GetAllProjeTanimlari() : IRequest<Result<List<ProjeTanimlari>>>;
}
