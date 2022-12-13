using System.ComponentModel.DataAnnotations;

using WebApp2022.Core.Models.Towns;

namespace WebApp2022.Models
{
    public class RegisterViewModel
    {
        public RegisterViewModel()
        {
            Towns = new List<TownViewModel>();
        }

        [Required]
        [MaxLength(20)]
        [MinLength(5)]
        public string UserName { get; set; } = null!;

        [Required]
        [DataType(DataType.EmailAddress)]
        [MaxLength(60)]
        [MinLength(5)]
        public string Email { get; set; } = null!;

        [Required]
        [MaxLength(20)]
        [MinLength(5)]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } = null!;

        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$")]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        [MaxLength(20)]
        [MinLength(4)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(20)]
        [MinLength(4)]
        public string LastName { get; set; } = null!;

        [Required]
        public string Town { get; set; } = null!;

        public List<TownViewModel> Towns { get; set; }
    }
}
