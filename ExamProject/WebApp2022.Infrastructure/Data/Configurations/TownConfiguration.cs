using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApp2022.Infrastructure.Data.Configurations
{
    internal class TownConfiguration : IEntityTypeConfiguration<Town>
    {
        public void Configure(EntityTypeBuilder<Town> builder)
        {
            builder
                .Property(t => t.IsApproved)
                .HasDefaultValue(false);

            builder.HasData(new List<Town>
            {
                new Town
                {
                    Id = Guid.Parse("658cfb89-2396-438d-baea-c10ef9ba492f"),
                    Name = "Veliko Tarnovo",
                    IsApproved = true
                },
                new Town
                {
                    Id = Guid.Parse("651dc286-24dd-473e-8099-a56ad3e7a6e2"),
                    Name = "Sofia",
                    IsApproved = false
                },
                new Town
                {
                    Id = Guid.Parse("d3e30c24-857f-4cd0-ba75-b9accb4d7c9f"),
                    Name = "Lovech",
                    IsApproved = true
                },
                new Town
                {
                    Id = Guid.Parse("db7127bc-1d68-4b3b-a523-a68a78b7e4a8"),
                    Name = "Pleven",
                    IsApproved = true
                },
                new Town
                {
                    Id = Guid.Parse("d6ce7d29-6f17-478d-af2f-b45fb212dd02"),
                    Name = "Plovdiv",
                    IsApproved = false
                },
                new Town
                {
                    Id = Guid.Parse("6fb2fef5-b16e-49dd-bfc4-8aef199df54c"),
                    Name = "Pavlikeni",
                    IsApproved = true
                }
            });
        }
    }
}
