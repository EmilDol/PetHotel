using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TravelEquipmentRenting.Infrastructure.Data.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            var products = new List<Product>()
            {
                new Product
                {
                    Id = Guid.Parse("4b8ec921-8cd7-4020-bbc3-e31e6d40aee3"),
                    DateAdded = DateTime.UtcNow,
                    Name = "Espadrilles",
                    Description = "Gianluigi Donnarumma Giancarlito PinocchLorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the",
                    IsApproved = true,
                    IsAvailable = true,
                    ImageUrl = "https://media.istockphoto.com/id/537373196/photo/trees-forming-a-heart.jpg?s=612x612&w=0&k=20&c=onZKNjkycICe4q2ZDnKi39z42Ax9tpZT7pph-2e5Seo=",
                    PricePerDay = 10,
                    OwnerId = "dea12856-c198-4129-b3f3-b893d8395082"
                },
                new Product
                {
                    Id = Guid.Parse("e97af452-0689-46a0-8739-04a880b25286"),
                    DateAdded= DateTime.UtcNow,
                    Name = "TestNotApproved",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has",
                    IsAvailable = true,
                    IsApproved = false,
                    ImageUrl = "https://www.apple.com/newsroom/images/product/iphone/lifestyle/Apple-Shot-on-iPhone-macro-Guido-Cassanelli_inline.jpg.large.jpg",
                    PricePerDay = 10,
                    OwnerId = "dea12856-c198-4129-b3f3-b893d8395082"
                },
                new Product
                {
                    Id = Guid.Parse("96d4e994-9559-48cb-b9c1-8eb77a96099b"),
                    DateAdded = DateTime.UtcNow,
                    IsApproved = true,
                    IsAvailable = true,
                    Name = "Test1",
                    Description = "Asdasdasdasdasd dasdhaoshgaifgvhqoudb aoidgaudgbiaf",
                    ImageUrl = "https://media.istockphoto.com/id/1216425366/photo/heart-and-soul.jpg?s=612x612&w=0&k=20&c=bj4RaFi61ToNPKaHfszM1ShMjl3Lf_Qg0FvhkV1eM0s=",
                    PricePerDay = 25,
                    OwnerId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e"
                }
            };

            builder.HasData(products);
        }
    }
}
