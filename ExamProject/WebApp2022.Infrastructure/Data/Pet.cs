using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

using WebApp2022.Infrastructure.Data.Enums;

namespace WebApp2022.Infrastructure.Data
{
    public class Pet
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Name { get; set; } = null!;

        [Required]
        [MinLength(20)]
        [MaxLength(300)]
        public string Description { get; set; } = null!;

        [Required]
        [MaxLength(200)]
        public string Requirements { get; set; } = null!;

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
        public bool NeedBabysitting { get; set; }

        public bool IsBabysittedNow { get; set; }

        [Required]
        public double Heigth { get; set; }

        [Required]
        public double Weigth { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public AnimalType Type { get; set; }

        [InverseProperty(nameof(Data.Announcement.Pet))]
        public Announcement? Announcement { get; set; }
    }
}
