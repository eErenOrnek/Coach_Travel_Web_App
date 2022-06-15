using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coach_Travel_Web_App.Identity
{
    public class SeedIdentity
    {
        public static async Task Seed(UserManager<User> userManager, RoleManager<IdentityRole> roleManager, ICardService cardService, IConfiguration configuration)
        {
            var adminUserName = configuration["UserData:AdminUser:UserName"];
            var adminPassword = configuration["UserData:AdminUser:Password"];
            var adminEmail = configuration["UserData:AdminUser:Email"];
            var adminRole = configuration["UserData:AdminUser:Role"];
            if (await userManager.FindByNameAsync(adminUserName) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(adminRole));
                var adminUser = new User()
                {
                    FirstName = "sys",
                    LastName = "Admin",
                    UserName = adminUserName,
                    Email = adminEmail,
                    EmailConfirmed = true
                };
                var result = await userManager.CreateAsync(adminUser, adminPassword);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, adminRole);
                }
            }

            var customerUserName = configuration["UserData:CustomerUser:UserName"];
            var customerPassword = configuration["UserData:CustomerUser:Password"];
            var customerEmail = configuration["UserData:CustomerUser:Email"];
            var customerRole = configuration["UserData:CustomerUser:Role"];
            if (await userManager.FindByNameAsync(customerUserName) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(customerRole));
                var customerUser = new User()
                {
                    FirstName = "First",
                    LastName = "Customer",
                    UserName = customerUserName,
                    Email = customerEmail,
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(customerUser, customerPassword);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(customerUser, customerRole);
                }
            }
        }

        internal static object Seed(object userManager, object roleManager, IConfiguration configuration)
        {
            throw new NotImplementedException();
        }
    }
}
