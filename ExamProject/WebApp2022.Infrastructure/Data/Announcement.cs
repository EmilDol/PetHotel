using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace WebApp2022.Infrastructure.Data
{
    public class Announcement
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Precision(18, 2)]
        public decimal OfferedPaying { get; set; }

        [Required]
        public bool IsAvailable { get; set; }

        [Required]
        public DateTime DayStarting { get; set; }

        [Required]
        public DateTime DayEnding { get; set; }

        [Required]
        [ForeignKey(nameof(Pet))]
        public Guid PetId { get; set; }

        public Pet Pet { get; set; } = null!;
    }
}
