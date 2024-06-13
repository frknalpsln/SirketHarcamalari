using Harcama.Business.Abstract;
using Harcama.Business.Concrete;
using Harcama.DataAccess.Abstract;
using Harcama.DataAccess.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harcama.Business
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {

            services.AddAutoMapper(typeof(ServiceRegistration).Assembly);

            services.AddMediatR(configuration =>
            {
                configuration.RegisterServicesFromAssembly(typeof(ServiceRegistration).Assembly);
            });

            services.AddScoped<IHarcamaBirimleriServices, HarcamaBirimleriManager>();
            services.AddScoped<IHarcamaTalepleriServices, HarcamaTalepleriManager>();
            services.AddScoped<IKullaniciBirimYetkileriServices, KullaniciBirimYetkileriManager>();
            services.AddScoped<IKullaniciSirketleriServices, KullaniciSirketleriManager>();
            services.AddScoped<IProjeTanimlariServices, ProjeTanimlariManager>();
            services.AddScoped<ISirketServices, SirketManager>();

            return services;
        }
    }
}
