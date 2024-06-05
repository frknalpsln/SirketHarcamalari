using Harcama.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using TS.Result;

namespace Harcama.WebAPI
{
    public static class Helper
    {
        public static async Task CreateUsersAsync(WebApplication app)
        {

            using (var scoped = app.Services.CreateScope())
            {
                var userManager = scoped.ServiceProvider.GetRequiredService<UserManager<AppUser>>();

                if (!userManager.Users.Any())
                {
                    string[][] usersInfo = new string[][]
                    {
            new string[] { "Admin", "Admin", "11164004322", "Ankara", "admin@admin.com", "admin", "Admin123" },
            new string[] { "Muhasebe", "Muhasebe", "11164004323", "Ankara", "muhasebe@muhasebe.com", "muhasebe", "Muhasebe123" }
                    };

                    foreach (var userInfo in usersInfo)
                    {
                        await userManager.CreateAsync(new AppUser
                        {
                            Adi = userInfo[0],
                            Soyadi = userInfo[1],
                            Tc = userInfo[2],
                            Adres = userInfo[3],
                            Email = userInfo[4],
                            UserName = userInfo[5]
                        }, userInfo[6]);
                    }
                }
            }

        }
    }
}