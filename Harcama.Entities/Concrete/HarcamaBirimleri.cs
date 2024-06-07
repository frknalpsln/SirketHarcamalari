using Harcama.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harcama.Entities.Concrete
{
    public class HarcamaBirimleri : BaseEntity
    {
        public string BirimAdi { get; set; }
        public string BirimKodu { get; set; }
        public string BirimYetkili { get; set; }
        public string BirimYetkiliTelefon { get; set; }
        public bool Durum {  get; set; }

        public Guid SirketId { get; set; }

        public Sirket Sirket { get; set; }
        public ICollection<HarcamaTalepleri> HarcamaTalepleri { get; set;}
    }
}
