using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace TravelEquipmentRenting.Infrastructure.Data
{
    public class Rental
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        [ForeignKey(nameof(Tenant))]
        public string TenantId { get; set; } = null!;

        public ApplicationUser Tenant { get; set; } = null!;

        [Precision(18, 2)]
        public decimal? TotalPrice { get; set; }

        [Required]
        [ForeignKey(nameof(Product))]
        public Guid ProductId { get; set; }

        public Product Product { get; set; } = null!;
    }
}
