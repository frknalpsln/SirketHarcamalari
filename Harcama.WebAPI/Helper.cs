using Harcama.Entities.Concrete;
using Microsoft.AspNetCore.Identity;

namespace Harcama.WebAPI
{
    public static class Helper
    {
        public static async Task CreateUsersAsync(WebApplication app)
        {
            using (var scoped = app.Services.CreateScope())
            {
                var userManager = scoped.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
                var roleManager = scoped.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                // "Admin" rolünü oluştur
                if (!await roleManager.RoleExistsAsync("Admin"))
                {
                    await roleManager.CreateAsync(new IdentityRole("Admin"));
                }

                // "Muhasebe" rolünü oluştur
                if (!await roleManager.RoleExistsAsync("Muhasebe"))
                {
                    await roleManager.CreateAsync(new IdentityRole("Muhasebe"));
                }

                // "admin" kullanıcısını oluştur ve "Admin" rolünü ata
                var adminUser = new AppUser
                {
                    Adi = "Furkan",
                    Soyadi = "Alpaslan",
                    Email = "admin@admin.com",
                    UserName = "admin"
                };
                var adminPassword = "Admin123!";
                if (await userManager.FindByNameAsync(adminUser.UserName) == null)
                {
                    var result = await userManager.CreateAsync(adminUser, adminPassword);
                    if (result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(adminUser, "Admin");
                    }
                }

                // "muhasebe" kullanıcısını oluştur ve "Muhasebe" rolünü ata
                var muhasebeUser = new AppUser
                {
                    Adi = "John",
                    Soyadi = "Doe",
                    Email = "muhasebe@example.com",
                    UserName = "muhasebe"
                };
                var muhasebePassword = "Muhasebe123!";
                if (await userManager.FindByNameAsync(muhasebeUser.UserName) == null)
                {
                    var result = await userManager.CreateAsync(muhasebeUser, muhasebePassword);
                    if (result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(muhasebeUser, "Muhasebe");
                    }
                }
            }
        }
    }
}