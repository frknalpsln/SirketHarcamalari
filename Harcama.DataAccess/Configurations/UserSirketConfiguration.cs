using Harcama.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harcama.DataAccess.Configurations
{
    public class UserSirketConfiguration : IEntityTypeConfiguration<KullaniciSirketleri>
    {
        public void Configure(EntityTypeBuilder<KullaniciSirketleri> builder)
        {
            builder.HasKey(k => new {k.UserId , k.SirketId});
        }
    }
}
