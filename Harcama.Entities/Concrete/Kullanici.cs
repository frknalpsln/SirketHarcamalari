using Harcama.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harcama.Entities.Concrete
{
    public class Kullanici : BaseEntity
    {
        public string Tc {  get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre {  get; set; }
        public string Email { get; set; }
        public string TelefonNo { get; set; }
        public string Adres {  get; set; }
    }
}
