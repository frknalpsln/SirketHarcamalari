using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harcama.Entities.Concrete
{
    public class AppRole : IdentityRole<Guid>
    {
        public ICollection<AppUser> Users { get; set; }
    }
}
