using Harcama.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using TS.Result;

namespace Harcama.WebAPI
{
    public static class Helper
    {
        public static async Task CreateRoleAsync(WebApplication app)
        {

            using (var scoped = app.Services.CreateScope())
            {
                var roleManager = scoped.ServiceProvider.GetRequiredService<RoleManager<AppRole>>();

                if (!roleManager.Roles.Any())
                {
                    AppRole[] appRoles =
                    {
                        new AppRole { Name = "Personel" },
                        new AppRole { Name = "Admin" },
                        new AppRole { Name = "Muhasebe" }
                    };
                    foreach (var role in appRoles)
                    {
                        await roleManager.CreateAsync(role);
                    };
                }
            }
        }

        public static async Task CreateUsersAsync(WebApplication app)
        {

            using (var scoped = app.Services.CreateScope())
            {
                var userManager = scoped.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
                var roleManager = scoped.ServiceProvider.GetRequiredService<RoleManager<AppRole>>();

                if (!userManager.Users.Any())
                {
                    AppUser admin = new AppUser
                    {
                        Adi = "Admin",
                        Soyadi = "Admin",
                        Tc = "11164004322",
                        Adres = "Ankara",
                        Email = "admin@admin.com",
                        UserName = "admin",
                    };


                    AppUser muhasebe = new AppUser
                    {
                        Adi = "Muhasebe",
                        Soyadi = "Muhasebe",
                        Tc = "11164004322",
                        Adres = "Ankara",
                        Email = "muhasebe@muhasebe.com",
                        UserName = "muhasebe",
                    };
                    await userManager.CreateAsync(admin);

                    await userManager.AddToRoleAsync(admin, "Admin");
                    await userManager.CreateAsync(muhasebe);

                    await userManager.AddToRoleAsync(muhasebe, "Muhasebe");

                }
            }

        }

    }
}