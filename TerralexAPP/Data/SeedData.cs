using Microsoft.AspNetCore.Identity;

namespace TerralexAPP.Data
{
    public static class SeedData
    {
        public static async Task InitializeAsync(RoleManager<ApplicationRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            //To Add Initial Roles
            string[] roleNames = { "Admin", "Manager", "Staff", "Client" };
            foreach (var roleName in roleNames)
            {
                if (!await roleManager.RoleExistsAsync(roleName))
                {
                    var role = new ApplicationRole
                    {
                        Name = roleName
                    };
                    await roleManager.CreateAsync(role);
                }
            }

            // To Add Initial Admin User
            var adminEmail = "admin@Terralex.com";
            var adminUser = await userManager.FindByEmailAsync(adminEmail);

            if (adminUser == null)
            {
                adminUser = new ApplicationUser
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    EmailConfirmed = true
                };
                var result = await userManager.CreateAsync(adminUser, "Admin@123456");
                if (result.Succeeded)
                {
                    // To Assign Admin Role to the Admin User
                    await userManager.AddToRoleAsync(adminUser, "Admin");
                }
            }
        }
    }
}
