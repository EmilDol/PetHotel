using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelEquipmentRenting.Infrastructure.Data
{
    public class Comment
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(20)]
        public string Title { get; set; } = null!;

        [Required]
        [MinLength(10)]
        [MaxLength(200)]
        public string Content { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Author))]
        public string AuthorId { get; set; } = null!;

        public ApplicationUser Author { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Receiver))]
        public string ReceiverId { get; set; } = null!;

        public ApplicationUser Receiver { get; set; } = null!;
    }
}
