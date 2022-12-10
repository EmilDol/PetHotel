using System.ComponentModel.DataAnnotations;

namespace WebApp2022.Core.Models.Comments
{
    public class CommentAddViewModel
    {
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
        public string ReceiverId { get; set; } = null!;
    }
}
