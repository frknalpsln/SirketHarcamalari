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
        public string Aciklama { get; set; }
        public string Gerekce { get; set; }
        public bool OnaylandiMi { get; set; }
        public DateTime Tarih {  get; set; }
        public string Tutar {  get; set; }

        public Guid UserId { get; set; }
        public Guid ProjeId { get; set; }

        public ProjeTanimlari ProjeTanimlari { get; set; }
        public AppUser User { get; set; }
    }
}
