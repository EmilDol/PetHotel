using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using WebApp2022.Core.Contracts;
using WebApp2022.Core.Models.Account;
using WebApp2022.Infrastructure.Data;
using WebApp2022.Infrastructure.Data.Common;

namespace WebApp2022.Core.Services
{
    public class AccountService : IAccountService
    {
        private readonly IRepository repository;
        private readonly ITownService townService;

        public AccountService(IRepository repository, ITownService townService)
        {
            this.repository = repository;
            this.townService = townService;
        }

        public async Task Edit(EditAccountViewModel model, string userId)
        {
            var user = await repository.All<ApplicationUser>().FirstAsync(u => u.Id == userId);

            user.UserName = model.UserName;
            user.PhoneNumber = model.PhoneNumber;
            user.PhoneNumberConfirmed = false;
            user.FirstName = model.FirstName;
            user.Email = model.Email;
            user.EmailConfirmed = false;
            user.LastName = model.LastName;
            user.TownId = Guid.Parse(model.Town);
            user.NormalizedEmail = model.Email.ToUpper();
            user.NormalizedUserName = model.UserName.ToUpper();

            await repository.SaveChangesAsync();
        }

        public async Task<EditAccountViewModel> MapUserToViewModel(string userId)
        {
            var user = await repository.All<ApplicationUser>().FirstAsync(u => u.Id == userId);
            var model = new EditAccountViewModel
            {
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber,
                UserName = user.UserName,
                Town = user.TownId.ToString(),
                Towns = await townService.GetTowns()
            };

            return model;
        }
    }
}
