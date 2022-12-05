using System.ComponentModel.DataAnnotations;

namespace WebApp2022.Core.Models.Announcements
{
    public class AnnouncementAddViewModel
    {
        [Required]
        public decimal OfferedPaying { get; set; }

        [Required]
        public DateTime DayStarting { get; set; }

        [Required]
        public DateTime DayEnding { get; set; }

        [Required]
        public Guid PetId { get; set; }
    }
}
