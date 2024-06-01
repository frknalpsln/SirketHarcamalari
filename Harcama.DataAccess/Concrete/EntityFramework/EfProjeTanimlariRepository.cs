using Harcama.DataAccess.Abstract;
using Harcama.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harcama.DataAccess.Concrete.EntityFramework
{
    public class EfProjeTanimlariRepository : EfEntityRepository<ProjeTanimlari>, IProjeTanimlariRepository
    {
        public EfProjeTanimlariRepository(HarcamaDbContext context) : base(context)
        {
        }
    }
}
