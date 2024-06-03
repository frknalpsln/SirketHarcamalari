using Harcama.Entities.Common;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harcama.Entities.Concrete
{
    public class AppUser : IdentityUser<Guid>
    {
        public string Tc {  get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }       
        public string Adres {  get; set; }
    }
}
