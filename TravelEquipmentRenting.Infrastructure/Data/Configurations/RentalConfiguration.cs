using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TravelEquipmentRenting.Infrastructure.Data.Configurations
{
    internal class RentalConfiguration : IEntityTypeConfiguration<Rental>
    {
        public void Configure(EntityTypeBuilder<Rental> builder)
        {
            var rental = new List<Rental>()
            {
                new Rental
                {
                    Id =Guid.Parse("46b1c11e-dbd0-432a-9bbc-b9cf6d6adfd4"),
                    ProductId = Guid.Parse("4b8ec921-8cd7-4020-bbc3-e31e6d40aee3"),
                    StartDate = DateTime.UtcNow,
                    TenantId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                }
            };

            builder.HasData(rental);
        }
    }
}
