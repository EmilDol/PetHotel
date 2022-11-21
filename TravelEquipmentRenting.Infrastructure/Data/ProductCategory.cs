using System.ComponentModel.DataAnnotations.Schema;

namespace TravelEquipmentRenting.Infrastructure.Data
{
    //TODO Make PK
    [Table("ProductsCategories")]
    public class ProductCategory
    {
        [ForeignKey(nameof(Product))]
        public Guid ProductId { get; set; }

        public Product Product { get; set; } = null!;

        [ForeignKey(nameof(Category))]
        public Guid CategoryId { get; set; }

        public Category Category { get; set; } = null!;
    }
}
