using Harcama.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harcama.Entities.Concrete
{
    public class KullaniciSirketleri : BaseEntity
    {
       
        public Guid KullaniciId { get; set; }
        public Guid SirketId { get; set; }

        public AppUser Kullanici { get; set; }
        public Sirket Sirket { get; set; }
    }
}
