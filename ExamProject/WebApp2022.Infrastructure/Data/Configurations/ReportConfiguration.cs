using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApp2022.Infrastructure.Data.Configurations
{
    internal class ReportConfiguration : IEntityTypeConfiguration<Report>
    {
        public void Configure(EntityTypeBuilder<Report> builder)
        {
            builder
                .HasOne(f => f.ReportedUser);

            //var rental = new List<Report>()
            //{
            //    new Report
            //    {
            //        Id =Guid.Parse("46b1c11e-dbd0-432a-9bbc-b9cf6d6adfd4"),
            //        ProductId = Guid.Parse("4b8ec921-8cd7-4020-bbc3-e31e6d40aee3"),
            //        StartDate = DateTime.UtcNow,
            //        TenantId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
            //    }
            //};

            //builder.HasData(rental);
        }
    }
}
