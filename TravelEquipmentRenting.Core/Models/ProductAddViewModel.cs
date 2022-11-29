using System.ComponentModel.DataAnnotations;

namespace TravelEquipmentRenting.Core.Models
{
    public class ProductAddViewModel
    {
        public ProductAddViewModel()
        {
            Categories = new List<CategoryViewModel>();
            CategoriesFormUI = new List<Guid>();
        }

        public Guid Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Name { get; set; } = null!;

        [Required]
        [MinLength(20)]
        [MaxLength(200)]
        public string Description { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        public decimal PricePerDay { get; set; }

        public List<Guid> CategoriesFormUI { get; set; }

        public List<CategoryViewModel> Categories { get; set; }
    }
}
