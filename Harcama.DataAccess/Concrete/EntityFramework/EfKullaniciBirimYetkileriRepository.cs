using Harcama.DataAccess.Abstract;
using Harcama.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harcama.DataAccess.Concrete.EntityFramework
{
    public class EfKullaniciBirimYetkileriRepository : EfEntityRepository<KullaniciBirimYetkileri>, IKullaniciBirimYetkileriRepository
    {
        public EfKullaniciBirimYetkileriRepository(HarcamaDbContext context) : base(context)
        {
        }
    }
}
