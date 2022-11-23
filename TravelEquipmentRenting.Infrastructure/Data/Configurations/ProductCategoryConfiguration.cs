using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TravelEquipmentRenting.Infrastructure.Data.Configurations
{
    internal class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            var productCategory = new List<ProductCategory>
            {
                new ProductCategory
                {
                    ProductId = Guid.Parse("4b8ec921-8cd7-4020-bbc3-e31e6d40aee3"),
                    CategoryId = Guid.Parse("fed5527f-721f-43b7-ba3e-8d4160cc714c")
                },
                new ProductCategory
                {
                    ProductId = Guid.Parse("4b8ec921-8cd7-4020-bbc3-e31e6d40aee3"),
                    CategoryId = Guid.Parse("39a87631-5fc3-4c14-b96f-dec2408600a5")
                },
                new ProductCategory
                {
                    ProductId = Guid.Parse("e97af452-0689-46a0-8739-04a880b25286"),
                    CategoryId = Guid.Parse("ae9f7553-eaae-45fe-8e15-12ec6187f980")
                },
                new ProductCategory
                {
                    ProductId = Guid.Parse("e97af452-0689-46a0-8739-04a880b25286"),
                    CategoryId = Guid.Parse("39a87631-5fc3-4c14-b96f-dec2408600a5")
                },
                new ProductCategory
                {
                    ProductId = Guid.Parse("96d4e994-9559-48cb-b9c1-8eb77a96099b"),
                    CategoryId = Guid.Parse("ae9f7553-eaae-45fe-8e15-12ec6187f980")
                }
            };
        }
    }
}
