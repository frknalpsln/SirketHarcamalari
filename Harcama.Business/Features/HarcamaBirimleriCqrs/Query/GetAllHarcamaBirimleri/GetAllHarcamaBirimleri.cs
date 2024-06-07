using Harcama.Entities.Concrete;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace Harcama.Business.Features.HarcamaBirimleriCqrs.Query.GetAllHarcamaBirimleri
{
    public record GetAllHarcamaBirimleri() : IRequest<Result<List<HarcamaBirimleri>>>;
}
