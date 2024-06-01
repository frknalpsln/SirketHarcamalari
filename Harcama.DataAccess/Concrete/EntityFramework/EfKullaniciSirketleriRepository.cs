using Harcama.DataAccess.Abstract;
using Harcama.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harcama.DataAccess.Concrete.EntityFramework
{
    public class EfKullaniciSirketleriRepository : EfEntityRepository<KullaniciSirketleri>, IKullaniciSirketleriRepository
    {
        public EfKullaniciSirketleriRepository(HarcamaDbContext context) : base(context)
        {
        }
    }
}
