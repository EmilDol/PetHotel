using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TravelEquipmentRenting.Infrastructure.Data.Configurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new List<Category>
            {
                new Category
                {
                    Id = Guid.Parse("39a87631-5fc3-4c14-b96f-dec2408600a5"),
                    Name = "Beginer Friendly"
                },
                new Category
                {
                    Id = Guid.Parse("fed5527f-721f-43b7-ba3e-8d4160cc714c"),
                    Name = "Shoes"
                },
                new Category
                {
                    Id = Guid.Parse("ae9f7553-eaae-45fe-8e15-12ec6187f980"),
                    Name = "Winter suitable"
                }
            });
        }
    }
}
