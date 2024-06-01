using Harcama.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harcama.Entities.Concrete
{
    public class KullaniciBirimYetkileri : BaseEntity
    {
       

        public Kullanici Kullanici { get; set; }
        public HarcamaBirimleri Birim { get; set; }
    }
}
