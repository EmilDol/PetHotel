using Microsoft.AspNetCore.Identity;

using WebApp2022.Infrastructure.Data;

namespace WebApp2022.Extensions
{
    public static class ApplicationBuilderExtension
    {
        public static IApplicationBuilder SeedAdmin(this IApplicationBuilder app)
        {
            using IServiceScope scopedServices = app.ApplicationServices.CreateScope();

            IServiceProvider services = scopedServices.ServiceProvider;

            UserManager<ApplicationUser> userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
            RoleManager<IdentityRole> roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

            Task.Run(async () =>
            {
                if (!await roleManager.RoleExistsAsync("Admin"))
                {
                    IdentityRole adminRole = new IdentityRole("Admin");
                    await roleManager.CreateAsync(adminRole);
                }

                if (!await roleManager.RoleExistsAsync("User"))
                {
                    IdentityRole userRole = new IdentityRole("User");
                    await roleManager.CreateAsync(userRole);
                }

                ApplicationUser admin = await userManager.FindByNameAsync("admin");
                await userManager.AddToRoleAsync(admin, "Admin");
            })
            .GetAwaiter()
            .GetResult();

            return app;
        }
    }
}
