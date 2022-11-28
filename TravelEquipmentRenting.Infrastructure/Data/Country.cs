using System.ComponentModel.DataAnnotations;

namespace TravelEquipmentRenting.Infrastructure.Data
{
    public class Country
    {
        public Country()
        {
            Towns = new List<Town>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(3)]
        public string Name { get; set; } = null!;

        [Required]
        public bool IsApproved { get; set; }

        public List<Town> Towns { get; set; }
    }
}
