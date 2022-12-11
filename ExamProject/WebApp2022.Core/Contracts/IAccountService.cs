using WebApp2022.Core.Models.Account;
using WebApp2022.Core.Models.Comments;

namespace WebApp2022.Core.Contracts
{
    public interface IAccountService
    {
        Task<EditAccountViewModel> GetUserToEdit(string userId);
        Task Edit(EditAccountViewModel model, string userId);
        Task<bool> Exists(string id);
        Task<DetailsAccountViewModel> Details(string id);
        Task Report(ReportAddViewModel model);
        Task AddComment(CommentAddViewModel model, string userId);
    }
}
