﻿using Harcama.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harcama.Entities.Concrete
{
    public class ProjeTanimlari : BaseEntity
    {
        public string ProjeAdi { get; set; }
        public string ProjeTanimi { get; set; }
        public DateTime ProjeBaslangicTarihi { get; set; }
        public string ProjeYetkilisi { get; set; }

        public Guid BirimId { get; set; }
        public HarcamaBirimleri Birim { get; set; }
    }
}
