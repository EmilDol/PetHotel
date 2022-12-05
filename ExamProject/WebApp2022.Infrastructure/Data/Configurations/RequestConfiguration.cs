using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApp2022.Infrastructure.Data.Configurations
{
    public class RequestConfiguration : IEntityTypeConfiguration<Request>
    {
        public void Configure(EntityTypeBuilder<Request> builder)
        {
            builder
                .Property(r => r.IsConfirmed)
                .HasDefaultValue(false);

            builder
                .HasOne(p => p.Babysitter)
                .WithMany(p => p.Requests)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
