using System.ComponentModel.DataAnnotations;

namespace TravelEquipmentRenting.Infrastructure.Data
{
    public class Category
    {
        public Category()
        {
            Products = new List<ProductCategory>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(30)]
        public string Name { get; set; } = null!;

        public List<ProductCategory> Products { get; set; } = null!;
    }
}
