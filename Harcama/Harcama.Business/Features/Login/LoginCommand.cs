using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace Harcama.Business.Features.Login
{
    public record LoginCommand(
        string UserNameOrEmail,
        string Password) : IRequest<Result<LoginCommandResponse>>;
   
}
