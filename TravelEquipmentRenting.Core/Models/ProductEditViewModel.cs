using System.ComponentModel.DataAnnotations;

namespace TravelEquipmentRenting.Core.Models
{
    public class ProductEditViewModel
    {
        public ProductEditViewModel()
        {
            Categories = new List<CategoryViewModel>();
            CategoriesAdded = new List<Guid>();
            CategoryCheckboxesFromUI = new List<Guid>();
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
        public DateTime DateAdded { get; set; }

        public string? IsApproved { get; set; }

        [Required]
        public decimal PricePerDay { get; set; }

        public string? IsAvailable { get; set; }

        public List<CategoryViewModel> Categories { get; set; } = null!;

        public List<Guid> CategoriesAdded { get; set; }

        public List<Guid> CategoryCheckboxesFromUI { get; set; }
    }
}
