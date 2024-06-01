using Harcama.DataAccess.Abstract;
using Harcama.DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harcama.DataAccess.Concrete
{
    public static class ServiceRegistration
    {
        public static void AddDataAccessServices(this IServiceCollection services)
        {
            services.AddDbContext<HarcamaDbContext>(options => options.UseNpgsql());

            services.AddScoped<IHarcamaBirimleriRepository, EfHarcamaBirimleriRepository>();
            services.AddScoped<IHarcamaTalepleriRepository, EfHarcamaTalepleriRepository>();
            services.AddScoped<IKullaniciBirimYetkileriRepository, EfKullaniciBirimYetkileriRepository>();
            services.AddScoped<IKullaniciRepository, EfKullaniciRepository>();
            services.AddScoped<IKullaniciSirketleriRepository, EfKullaniciSirketleriRepository>();
            services.AddScoped<IProjeTanimlariRepository, EfProjeTanimlariRepository>();
            services.AddScoped<ISirketRepository, EfSirketRepository>();
        }
    }
}
