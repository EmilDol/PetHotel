using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace TravelEquipmentRenting.Infrastructure.Data
{
    public class Product
    {
        public Product()
        {
            Categories = new List<ProductCategory>();
        }

        [Key]
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
        [ForeignKey(nameof(Owner))]
        public string OwnerId { get; set; } = null!;

        public ApplicationUser Owner { get; set; } = null!;

        [Required]
        public DateTime DateAdded { get; set; }

        [Required]
        public bool IsApproved { get; set; }

        [Required]
        [Precision(18,2)]
        public decimal PricePerDay { get; set; }

        [Required]
        //TODO Set default value
        public bool IsAvailable { get; set; }

        public List<ProductCategory> Categories { get; set; } = null!;

        [InverseProperty(nameof(Data.Rental.Product))]
        public Rental? Rental { get; set; }
    }
}
