using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApp2022.Infrastructure.Data.Configurations
{
    internal class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var users = new List<ApplicationUser>();
            var hasher = new PasswordHasher<ApplicationUser>();

            var user = new ApplicationUser()
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                UserName = "agent@mail.com",
                NormalizedUserName = "AGENT@MAIL.COM",
                Email = "agent@mail.com",
                NormalizedEmail = "AGENT@MAIL.COM",
                FirstName = "Jamal",
                LastName = "Frederick",
                PhoneNumber = "0882854999",
                TownId = Guid.Parse("6fb2fef5-b16e-49dd-bfc4-8aef199df54c")
            };

            user.PasswordHash =
                 hasher.HashPassword(user, "agent123");

            users.Add(user);

            user = new ApplicationUser()
            {
                Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                UserName = "guest@mail.com",
                NormalizedUserName = "GUEST@MAIL.COM",
                Email = "guest@mail.com",
                NormalizedEmail = "GUEST@MAIL.COM",
                FirstName = "Ivan",
                LastName = "Georgiev",
                PhoneNumber = "0884305667",
                TownId = Guid.Parse("db7127bc-1d68-4b3b-a523-a68a78b7e4a8")
            };

            user.PasswordHash =
            hasher.HashPassword(user, "guest123");

            users.Add(user);

            builder.HasData(users);
        }
    }
}
