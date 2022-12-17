using System.ComponentModel.DataAnnotations;

namespace WebApp2022.Core.Models.Announcements
{
    public class AnnouncementAddViewModel
    {
        [Required]
        [Display(Name = "Offerd Paying in BGN")]
        public decimal OfferedPaying { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        public DateTime DayStarting { get; set; }

        [Required]
        [Display(Name = "End Date")]
        public DateTime DayEnding { get; set; }

        [Required]
        public Guid PetId { get; set; }
    }
}
