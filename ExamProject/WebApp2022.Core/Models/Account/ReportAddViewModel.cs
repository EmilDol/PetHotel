using System.ComponentModel.DataAnnotations;

namespace WebApp2022.Core.Models.Account
{
    public class ReportAddViewModel
    {
        [Required]
        public string UserId { get; set; } = null!;

        [Required]
        [MinLength(20)]
        [MaxLength(300)]
        public string Description { get; set; } = null!;
    }
}
