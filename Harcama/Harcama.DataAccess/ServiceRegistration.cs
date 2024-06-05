using Harcama.DataAccess.Abstract;
using Harcama.DataAccess.Concrete.EntityFramework;
using Harcama.DataAccess.Configurations;
using Harcama.DataAccess.Services;
using Harcama.DataAccess.Services.Concrete;
using Harcama.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
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
        public static IServiceCollection AddDataAccessServices(this IServiceCollection services)
        {
            services.AddDbContext<HarcamaDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));

            services.AddIdentity<AppUser, AppRole>(action =>
            {
                action.Password.RequiredLength = 1;
                action.Password.RequireUppercase = false;
                action.Password.RequireLowercase = false;
                action.Password.RequireNonAlphanumeric = false;
                action.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<HarcamaDbContext>();




            services.AddScoped<IHarcamaBirimleriRepository, EfHarcamaBirimleriRepository>();
            services.AddScoped<IHarcamaTalepleriRepository, EfHarcamaTalepleriRepository>();
            services.AddScoped<IKullaniciBirimYetkileriRepository, EfKullaniciBirimYetkileriRepository>();
            services.AddScoped<IKullaniciSirketleriRepository, EfKullaniciSirketleriRepository>();
            services.AddScoped<IProjeTanimlariRepository, EfProjeTanimlariRepository>();
            services.AddScoped<ISirketRepository, EfSirketRepository>();


            services.AddScoped<IJwtProvider, JwtProvider>();

            return services;

        }
    }
}
