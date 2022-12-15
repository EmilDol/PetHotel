using System.Globalization;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApp2022.Infrastructure.Data.Configurations
{
    public class AnnouncmentConfiguration : IEntityTypeConfiguration<Announcement>
    {
        public void Configure(EntityTypeBuilder<Announcement> builder)
        {
            var announcements = new List<Announcement>
            {
                new Announcement
                {
                    IsAvailable = true,
                    Id = Guid.Parse("7c712e77-a568-415c-ad7f-10ab554cd6e4"),
                    PetId = Guid.Parse("96d4e994-9559-48cb-b9c1-8eb77a96099b"),
                    OfferedPaying = 3000,
                    DayStarting = DateTime.Parse("28/12/2022"),
                    DayEnding = DateTime.Parse("06/01/2022")
                },
                new Announcement
                {
                    IsAvailable = false,
                    Id = Guid.Parse("15d01d36-951f-4599-a747-a4a4fd38d7b4"),
                    OfferedPaying = 150,
                    PetId = Guid.Parse("96d4e994-9559-48cb-b9c1-8eb77a96099b"),
                    DayStarting = DateTime.Parse("13/03/2023"),
                    DayEnding = DateTime.Parse("17/03/2023")
                },
                new Announcement
                {
                    IsAvailable = true,
                    PetId = Guid.Parse("4b8ec921-8cd7-4020-bbc3-e31e6d40aee3"),
                    Id = Guid.Parse("a8f31fcf-57af-432a-9f2e-c6856ee41031"),
                    OfferedPaying = 400,
                    DayStarting = DateTime.Parse("23/01/2023"),
                    DayEnding = DateTime.Parse("28/03/2023")
                }
            };


            builder.HasData(announcements);
        }
    }
}
