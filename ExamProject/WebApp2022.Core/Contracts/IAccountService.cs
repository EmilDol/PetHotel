using WebApp2022.Core.Models.Account;

namespace WebApp2022.Core.Contracts
{
    public interface IAccountService
    {
        Task<EditAccountViewModel> GetUserToEdit(string userId);
        Task Edit(EditAccountViewModel model, string userId);
        Task<bool> Exists(string id);
        Task<DetailsAccountViewModel> Details(string id);
    }
}
