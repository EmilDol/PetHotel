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

            var requests = new List<Request>
            {
                new Request
                {
                    Id = Guid.Parse("00ff1a5f-8b2f-4b84-999e-e524da8f461a"),
                    AnnouncementId = Guid.Parse("15d01d36-951f-4599-a747-a4a4fd38d7b4"),
                    IsConfirmed = true,
                    BabysitterId = "dea12856-c198-4129-b3f3-b893d8395082"
                },
                new Request
                {
                    Id = Guid.Parse("f0207fe1-af72-48de-88c3-28e76f33f588"),
                    AnnouncementId = Guid.Parse("7c712e77-a568-415c-ad7f-10ab554cd6e4"),
                    IsConfirmed = false,
                    BabysitterId = "dea12856-c198-4129-b3f3-b893d8395082"
                },
                new Request
                {
                    Id = Guid.Parse("52cfc479-066a-4772-94f0-c24826f9b357"),
                    AnnouncementId = Guid.Parse("7c712e77-a568-415c-ad7f-10ab554cd6e4"),
                    IsConfirmed = false,
                    BabysitterId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e"
                },
                new Request
                {
                    Id = Guid.Parse("01f39c0e-1b4a-4200-9469-094175666e4d"),
                    IsConfirmed = false,
                    AnnouncementId = Guid.Parse("a8f31fcf-57af-432a-9f2e-c6856ee41031"),
                    BabysitterId = "72153552-7b85-4e34-b236-290e9bbad012"
                }
            };

            builder.HasData(requests);
        }
    }
}
