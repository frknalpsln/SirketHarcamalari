using Harcama.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harcama.DataAccess.Concrete
{
    public class HarcamaDbContext : DbContext
    {
        public HarcamaDbContext(DbContextOptions<HarcamaDbContext> options) : base(options)
        {
        }
        public DbSet<HarcamaBirimleri> HarcamaBirimleri { get; set; }
        public DbSet<HarcamaTalepleri> HarcamaTalepleri { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<KullaniciBirimYetkileri> KullaniciBirimYetkileri { get; set; }
        public DbSet<KullaniciSirketleri> KullaniciSirketleri { get; set; }
        public DbSet<ProjeTanimlari> ProjeTanimlari { get; set; }
        public DbSet<Sirket> Sirketler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID=postgres;Password=1a2s3d+;Host=localhost;Port=5432;Database=harcamaDb;");
        }

    }
}
