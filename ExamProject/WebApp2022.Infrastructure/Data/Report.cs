using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp2022.Infrastructure.Data
{
    public class Report
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [ForeignKey(nameof(ReportedUser))]
        public string ReportedUserId { get; set; } = null!;

        public ApplicationUser ReportedUser { get; set; } = null!;

        [Required]
        [MinLength(20)]
        [MaxLength(300)]
        public string Description { get; set; } = null!;
    }
}
