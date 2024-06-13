using Harcama.DataAccess.Configurations;
using Harcama.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Harcama.DataAccess.Concrete
{
    public class HarcamaDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public HarcamaDbContext(DbContextOptions<HarcamaDbContext> options) : base(options)
        {
        }



        public DbSet<HarcamaBirimleri> HarcamaBirimleri { get; set; }
        public DbSet<HarcamaTalepleri> HarcamaTalepleri { get; set; }
        public DbSet<KullaniciBirimYetkileri> KullaniciBirimYetkileri { get; set; }
        public DbSet<KullaniciSirketleri> KullaniciSirketleri { get; set; }
        public DbSet<ProjeTanimlari> ProjeTanimlari { get; set; }
        public DbSet<Sirket> Sirketler { get; set; }


    }
}
