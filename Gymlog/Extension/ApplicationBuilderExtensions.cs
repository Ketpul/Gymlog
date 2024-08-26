using Gymlog.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using static Gymlog.Constants.RoleConstants;

namespace Gymlog.Extension
{
    public static class ApplicationBuilderExtensions
    {
        public static async Task CreateRoleAsync(this IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.CreateScope();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            if (userManager != null && roleManager != null && await roleManager.RoleExistsAsync(AdminRole) == false)
            {
                var role = new IdentityRole(AdminRole);
                await roleManager.CreateAsync(role);
            }

            var admin = await userManager.FindByEmailAsync("admin@gmail.com");

            if (admin != null)
            {
                await userManager.AddToRoleAsync(admin, AdminRole);
            }
        }
    }
}
