using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.AspNetCore.Identity;

namespace TravelEquipmentRenting.Infrastructure.Data
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            CommentsWritten = new List<Comment>();
        }

        [Required]
        [MaxLength(20)]
        [MinLength(2)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(20)]
        [MinLength(5)]
        public string LastName { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Town))]
        public Guid TownId { get; set; }

        public Town Town { get; set; }

        [InverseProperty(nameof(Comment.Author))]
        public List<Comment> CommentsWritten { get; set; }

        [InverseProperty(nameof(Comment.Receiver))]
        public List<Comment> CommentsReceived { get; set; }
    }
}
