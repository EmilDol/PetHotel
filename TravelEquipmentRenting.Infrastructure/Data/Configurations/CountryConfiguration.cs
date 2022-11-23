using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TravelEquipmentRenting.Infrastructure.Data.Configurations
{
    internal class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(new List<Country>
            {
                new Country
                {
                    Id = Guid.Parse("46c40eab-c926-4d8d-a972-ef4e925eae4f"),
                    Name = "Bulgaria"
                },
                new Country
                {
                    Id = Guid.Parse("ff00449c-58f1-45d3-9388-4ac2f5ce650d"),
                    Name = "Germany"
                },
                new Country
                {
                    Id = Guid.Parse("24e0def5-4df1-4d23-a45b-4548f2c4c89b"),
                    Name = "Serbia"
                }
            });
        }
    }
}
