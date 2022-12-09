using WebApp2022.Core.Models.Account;

namespace WebApp2022.Core.Contracts
{
    public interface IAccountService
    {
        Task<EditAccountViewModel> MapUserToViewModel(string userId);
        Task Edit(EditAccountViewModel model, string userId);
    }
}
