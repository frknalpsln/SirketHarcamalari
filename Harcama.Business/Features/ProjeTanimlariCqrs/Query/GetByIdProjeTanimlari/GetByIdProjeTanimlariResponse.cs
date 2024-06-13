using Harcama.Entities.Concrete;

namespace Harcama.Business.Features.ProjeTanimlariCqrs.Query.GetByIdProjeTanimlari
{
    public record GetByIdProjeTanimlariResponse(
     string ProjeAdi,
     string ProjeTanimi,
     DateTime ProjeBaslangic,
     string ProjeYetkilisi,
     Guid BirimId

       );
}
