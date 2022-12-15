using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using WebApp2022.Infrastructure.Data.Enums;

namespace WebApp2022.Infrastructure.Data.Configurations
{
    internal class PetConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder
                .Property(p => p.IsApproved)
                .HasDefaultValue(false);

            var products = new List<Pet>()
            {
                new Pet
                {
                    Id = Guid.Parse("4b8ec921-8cd7-4020-bbc3-e31e6d40aee3"),
                    DateAdded = DateTime.UtcNow,
                    Name = "Mishi",
                    Description = "Gianluigi Donnarumma Giancarlito PinocchLorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the",
                    IsApproved = true,
                    ImageUrl = "https://media.istockphoto.com/id/537373196/photo/trees-forming-a-heart.jpg?s=612x612&w=0&k=20&c=onZKNjkycICe4q2ZDnKi39z42Ax9tpZT7pph-2e5Seo=",
                    OwnerId = "dea12856-c198-4129-b3f3-b893d8395082",
                    Age = 3,
                    Heigth = 0.3,
                    Weigth = 4,
                    Type = AnimalType.Cat,
                    Requirements = "Needs to be played with and weekly beautition session"
                },
                new Pet
                {
                    Id = Guid.Parse("e97af452-0689-46a0-8739-04a880b25286"),
                    DateAdded= DateTime.UtcNow,
                    Name = "Pablo",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has",
                    IsApproved = false,
                    ImageUrl = "https://www.apple.com/newsroom/images/product/iphone/lifestyle/Apple-Shot-on-iPhone-macro-Guido-Cassanelli_inline.jpg.large.jpg",
                    OwnerId = "72153552-7b85-4e34-b236-290e9bbad012",
                    Type = AnimalType.Bugs,
                    Age = 36,
                    Heigth = 1.5,
                    Weigth = 5,
                    Requirements = "Every second full noon he goes to Tsvetelina Yaneva's concert"
                },
                new Pet
                {
                    Id = Guid.Parse("96d4e994-9559-48cb-b9c1-8eb77a96099b"),
                    DateAdded = DateTime.UtcNow,
                    IsApproved = true,
                    Name = "Juan",
                    Description = "Horsey. He big and likes balconies.",
                    ImageUrl = "https://i.kym-cdn.com/entries/icons/original/000/035/644/juancover.jpg",
                    OwnerId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                    Age = 69,
                    Heigth = 3,
                    Weigth = 420,
                    Type = AnimalType.Exotic,
                    Requirements = "He needs immediate access to every balcony in perementar of 1 km and to to his wife Juanita"
                },
                new Pet
                {
                    Id = Guid.Parse("38237218-53e9-413e-ade3-49b4a122922f"),
                    DateAdded = DateTime.UtcNow,
                    IsApproved = false,
                    Name = "Juanita",
                    Description = "Horsey. She big and likes balconies. She the beloved wife of Juan",
                    ImageUrl = "https://i.redd.it/4kc2skyohqx51.jpg",
                    OwnerId = "72153552-7b85-4e34-b236-290e9bbad012",
                    Age = 42,
                    Heigth = 2.85,
                    Weigth = 300,
                    Type = AnimalType.Bird,
                    Requirements = "Every evening she needs to hear her husband Juan"
                }
            };

            builder.HasData(products);
        }
    }
}
