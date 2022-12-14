using Microsoft.EntityFrameworkCore;

using WebApp2022.Core.Contracts.Administration;
using WebApp2022.Core.Models.Admin.Pets;
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

        public  async Task ApprovePet(Guid id)
        {
            var model = await repository.All<Pet>().FirstAsync(p => p.Id == id);
            model.IsApproved = true;
            await repository.SaveChangesAsync();
        }

        public async Task ApproveTown(Guid id)
        {
            var model = await repository.All<Town>().FirstAsync(t => t.Id == id);
            model.IsApproved = true;
            await repository.SaveChangesAsync();
        }

        public async Task<bool> ExistPet(Guid id)
        {
            var model = await repository.All<Pet>().FirstOrDefaultAsync(p => p.Id == id);

            if (model == null)
            {
                return false;
            }
            return true;
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

        public async Task<List<AllPetsApproveViewModel>> GetPets()
        {
            var model = await repository.All<Pet>()
                .Where(p => p.IsApproved == false)
                .Select(p => new AllPetsApproveViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Age = p.Age.ToString(),
                    Description = p.Description,
                    Requirements = p.Requirements,
                    Heigth = p.Heigth.ToString(),
                    ImageUrl = p.ImageUrl,
                    Weigth = p.Weigth.ToString(),
                    Type = p.Type.ToString()
                })
                .ToListAsync();

            return model;
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

        public async Task RejectPet(Guid id)
        {
            await repository.DeleteAsync<Pet>(id);
            await repository.SaveChangesAsync();
        }

        public async Task RejectTown(Guid id)
        {
            await repository.DeleteAsync<Town>(id);
            await repository.SaveChangesAsync();
        }
    }
}
