using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelEquipmentRenting.Infrastructure.Data
{
    public class Town
    {
        public Town()
        {
            Users = new List<ApplicationUser>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(4)]
        public string Name { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Country))]
        public Guid CountryId { get; set; }

        public Country Country { get; set; } = null!;

        public List<ApplicationUser> Users { get; set; }
    }
}
