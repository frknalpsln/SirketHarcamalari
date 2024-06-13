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
        string Adres,
        List<Guid> SirketId,
        List<Guid> BirimId) : IRequest<Result<RegisterCommandResponse>>;
}
