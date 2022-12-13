using Microsoft.EntityFrameworkCore;

using WebApp2022.Core.Contracts.Administration;
using WebApp2022.Core.Models.Admin.Towns;
using WebApp2022.Infrastructure.Data;
using WebApp2022.Infrastructure.Data.Common;

namespace WebApp2022.Core.Services.Administration
{
    public class ApproveService : IApproveService
    {
        private readonly IRepository repository;

        public ApproveService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task ApproveTown(Guid id)
        {
            var model = await repository.All<Town>().FirstAsync(t => t.Id == id);
            model.IsApproved = true;
            await repository.SaveChangesAsync();
        }

        public async Task<bool> ExistTown(Guid id)
        {
            var model = await repository.All<Town>().FirstOrDefaultAsync(m => m.Id == id);

            if (model == null)
            {
                return false;
            }
            return true;
        }

        public async Task<List<AllTownsApproveViewModel>> GetTowns()
        {
            var model = await repository.All<Town>()
                .Where(t => t.IsApproved == false)
                .Select(t => new AllTownsApproveViewModel
                {
                    Id = t.Id,
                    Name = t.Name
                })
                .ToListAsync();

            return model;
        }

        public async Task RejectTown(Guid id)
        {
            await repository.DeleteAsync<Town>(id);
            await repository.SaveChangesAsync();
        }
    }
}
