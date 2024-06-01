using Harcama.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harcama.Entities.Concrete
{
    public class HarcamaTalepleri : BaseEntity
    {
        public DateTime Tarih {  get; set; }
        public Kullanici TalepteBulunan { get; set; }
    }
}
