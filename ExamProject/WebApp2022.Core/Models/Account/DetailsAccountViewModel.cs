using WebApp2022.Core.Models.Comments;

namespace WebApp2022.Core.Models.Account
{
    public class DetailsAccountViewModel
    {
        public DetailsAccountViewModel()
        {
            Comments = new List<CommentUnderProfileViewModel>();
        }
        public string Id { get; set; }

        public string FullName { get; set; } = null!;

        public string UserName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;

        public string Town { get; set; } = null!;

        public List<CommentUnderProfileViewModel> Comments { get; set; }
    }
}
