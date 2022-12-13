using Microsoft.EntityFrameworkCore;

using WebApp2022.Core.Contracts;
using WebApp2022.Core.Models.Towns;
using WebApp2022.Infrastructure.Data;
using WebApp2022.Infrastructure.Data.Common;

namespace WebApp2022.Core.Services
{
    public class TownService : ITownService
    {
        private readonly IRepository repository;

        public TownService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task Add(string name)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                return;
            }
            if (await repository.All<Town>().Select(t => t.Name).ContainsAsync(name))
            {
                return;
            }
            var town = new Town
            {
                IsApproved = false,
                Name = name,
                Id = Guid.NewGuid()
            };
            await repository.AddAsync(town);
            await repository.SaveChangesAsync();
        }

        public async Task<List<TownViewModel>> GetTowns()
        {
            var model = await repository.All<Town>()
                .Where(t => t.IsApproved == true)
                .Select(t => new TownViewModel
                {
                    Name = t.Name,
                    Id = t.Id
                })
                .ToListAsync();

            return model;
        }
    }
}
