using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace Harcama.Business.Features.Register
{
    public record RegisterCommand(
        string Tc,
        string Adi,
        string Soyadi,
        string KullaniciAdi,
        string Sifre,
        string SifreTekrari,
        string Email,
        string Telefon,
        string Adres) : IRequest<Result<RegisterCommandResponse>>;


    public record RegisterCommandResponse();

    internal class RegisterCommandHandler : IRequestHandler<RegisterCommand, Result<RegisterCommandResponse>>
    {
        public Task<Result<RegisterCommandResponse>> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
