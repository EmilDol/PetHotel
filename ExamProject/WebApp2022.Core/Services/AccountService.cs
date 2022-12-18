using Ganss.Xss;

using Microsoft.EntityFrameworkCore;

using WebApp2022.Core.Contracts;
using WebApp2022.Core.Models.Account;
using WebApp2022.Core.Models.Comments;
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

        
        public async Task AddComment(CommentAddViewModel model, string userId)
        {
            var comment = new Comment
            {
                AuthorId = userId,
                Content = model.Content,
                ReceiverId = model.ReceiverId,
                Title = model.Title,
                Id = Guid.NewGuid()
            };

            await repository.AddAsync(comment);
            await repository.SaveChangesAsync();
        }

        public async Task<DetailsAccountViewModel> Details(string id)
        {
            var model = await repository.All<ApplicationUser>()
                .Where(u => u.Id == id)
                .Include(u => u.Town)
                .Select(u => new DetailsAccountViewModel
                {
                    PhoneNumber = u.PhoneNumber,
                    Email = u.Email,
                    UserName = u.UserName,
                    Town = u.Town.Name,
                    FullName = $"{u.FirstName} {u.LastName}",
                    Id = u.Id
                })
                .FirstAsync();

            model.Comments = await repository.All<Comment>()
                .Where(c => c.ReceiverId == id)
                .Include(c => c.Author)
                .Select(c => new CommentUnderProfileViewModel
                {
                    Content = c.Content,
                    Title = c.Title,
                    Author = $"{c.Author.FirstName} {c.Author.LastName}",
                    AuthorId = c.AuthorId
                })
                .ToListAsync();

            return model;
        }

        public async Task Edit(EditAccountViewModel model, string userId)
        {
            var sanitizer = new HtmlSanitizer();
            var user = await repository.All<ApplicationUser>().FirstAsync(u => u.Id == userId);

            user.UserName = sanitizer.Sanitize(model.UserName);
            user.PhoneNumber = sanitizer.Sanitize(model.PhoneNumber);
            user.PhoneNumberConfirmed = false;
            user.FirstName = sanitizer.Sanitize(model.FirstName);
            user.Email = model.Email;
            user.EmailConfirmed = false;
            user.LastName = sanitizer.Sanitize(model.LastName);
            user.TownId = Guid.Parse(model.Town);
            user.NormalizedEmail = sanitizer.Sanitize(model.Email.ToUpper());
            user.NormalizedUserName = sanitizer.Sanitize(model.UserName.ToUpper());

            await repository.SaveChangesAsync();
        }

        public async Task<bool> Exists(string id)
        {
            var user = await repository.All<ApplicationUser>().FirstOrDefaultAsync(u => u.Id == id);

            if (user == null)
            {
                return false;
            }
            return true;
        }

        public async Task<EditAccountViewModel> GetUserToEdit(string userId)
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
