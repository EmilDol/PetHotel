using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp2022.Infrastructure.Data
{
    public class Request
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [ForeignKey(nameof(Babysitter))]
        public string BabysitterId { get; set; } = null!;

        public ApplicationUser Babysitter { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Announcement))]
        public Guid AnnouncementId { get; set; }

        public Announcement Announcement { get; set; }

        [Required]
        public bool IsConfirmed { get; set; }

    }
}
