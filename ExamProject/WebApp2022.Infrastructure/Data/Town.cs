using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp2022.Infrastructure.Data
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
        public bool IsApproved { get; set; }

        public List<ApplicationUser> Users { get; set; }
    }
}
