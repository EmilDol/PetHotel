using Microsoft.EntityFrameworkCore;

using TravelEquipmentRenting.Core.Contracts;
using TravelEquipmentRenting.Core.Models;
using TravelEquipmentRenting.Infrastructure.Data;
using TravelEquipmentRenting.Infrastructure.Data.Common;

namespace TravelEquipmentRenting.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository repo;

        public ProductService(IRepository repo)
        {
            this.repo = repo;
        }

        public async Task<IEnumerable<ProductAllViewModel>> AllAsync(string userId)
        {
            var model = await repo.All<Product>()
                .Include(p => p.Owner)
                .Include(p => p.Categories)
                .ThenInclude(c => c.Category)
                .Where(p => p.OwnerId != userId && p.IsAvailable == true && p.IsApproved == true)
                .Select(p => new ProductAllViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    ImageUrl = p.ImageUrl,
                    OwnerName = $"{p.Owner.FirstName} {p.Owner.LastName}",
                    Categories = p.Categories
                        .Select(c => c.Category.Name)
                        .ToList()
                })
                .ToListAsync();

            foreach (var product in model)
            {
                product.CategoriesAsString = string.Join(", ", product.Categories);
            }

            return model;
        }

        public async Task<IEnumerable<ProductMineViewModel>> Mine(string userId)
        {
            var model = await repo.All<Product>()
                .Include(p => p.Owner)
                .Include(p => p.Categories)
                .ThenInclude(c => c.Category)
                .Where(p => p.OwnerId == userId)
                .Select(p => new ProductMineViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    ImageUrl = p.ImageUrl,
                    IsAvailable = p.IsAvailable == true ? "No" : "Yes",
                    IsApproved = p.IsApproved == true ? "Approved" : "Waiting for approval",
                    Categories = p.Categories
                        .Select(c => c.Category.Name)
                        .ToList()
                })
                .ToListAsync();

            foreach (var product in model)
            {
                product.CategoriesAsString = string.Join(", ", product.Categories);
            }

            return model;
        }
    }
}
