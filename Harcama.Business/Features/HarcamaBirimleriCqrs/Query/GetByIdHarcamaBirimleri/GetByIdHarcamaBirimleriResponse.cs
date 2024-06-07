namespace Harcama.Business.Features.HarcamaBirimleriCqrs.Query.GetByIdHarcamaBirimleri
{
    public record GetByIdHarcamaBirimleriResponse(
        string BirimAdi,
        string BirimKodu,
        string BirimYetkili,
        string BirimYetkiliTelefon);
}
