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
    public class UserBirimConfiguration : IEntityTypeConfiguration<KullaniciBirimYetkileri>
    {
        public void Configure(EntityTypeBuilder<KullaniciBirimYetkileri> builder)
        {
            builder.HasKey(k => new { k.UserId, k.BirimId});
        }
    }
}
