namespace Harcama.Business.Features.SirketCqrs.Query.GetByIdSirket
{
    public record GetByIdSirketResponse(
     string SirketAdi,
     string SirketKodu,
     string Adres,
     string TelefonNo);
}
