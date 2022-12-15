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
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@mail.com",
                NormalizedEmail = " ADMIN@MAIL.COM",
                FirstName = "Petar",
                LastName = "Petrov",
                PhoneNumber = "0882854999",
                TownId = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f")
            };

            user.PasswordHash =
                 hasher.HashPassword(user, "admin123!");

            users.Add(user);

            user = new ApplicationUser()
            {
                Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                UserName = "guest1",
                NormalizedUserName = "GUEST1",
                Email = "guest1@mail.com",
                NormalizedEmail = "GUEST1@MAIL.COM",
                FirstName = "Ivan",
                LastName = "Georgiev",
                PhoneNumber = "0884305667",
                TownId = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f")
            };

            user.PasswordHash =
                hasher.HashPassword(user, "guest1123!");

            users.Add(user);
            
            user = new ApplicationUser()
            {
                Id = "72153552-7b85-4e34-b236-290e9bbad012",
                UserName = "guest2",
                NormalizedUserName = "GUEST2",
                Email = "guest2@mail.com",
                NormalizedEmail = "GUEST2@MAIL.COM",
                FirstName = "Boyan",
                LastName = "Hristov",
                PhoneNumber = "0854993215",
                TownId = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f")
            };

            user.PasswordHash =
                hasher.HashPassword(user, "guest2123!");

            users.Add(user);

            builder.HasData(users);
        }
    }
}
