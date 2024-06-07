using Harcama.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harcama.Entities.Concrete
{
    public class Sirket : BaseEntity
    {
        public string SirketAdi { get; set; }
        public string SirketKodu { get; set; }
        public bool Durum { get; set; }
        public string Adres { get; set; }
        public string TelefonNo { get; set; }
        public ICollection<ProjeTanimlari> ProjeTanimlari { get; set; }
        public ICollection<HarcamaBirimleri> HarcamaBirimleri { get; set; }

    }
}
