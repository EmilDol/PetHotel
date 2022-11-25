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

        public async Task Edit(ProductEditViewModel model)
        {
            var product = await repo.All<Product>().Include(p => p.Categories).FirstAsync(p => p.Id == model.Id);

            product.Name = model.Name;
            product.Description = model.Description;
            product.ImageUrl = model.ImageUrl;
            product.PricePerDay = model.PricePerDay;
            product.IsApproved = false;
            product.Categories = new List<ProductCategory>();

            foreach (var category in model.Categories)
            {
                if (category.IsTagged)
                {
                    ProductCategory productCategory = new ProductCategory()
                    {
                        CategoryId = category.Id,
                        Product = product
                    };
                    product.Categories.Add(productCategory);
                }
            }

            await repo.SaveChangesAsync();
        }

        public async Task<bool> Exists(Guid id)
        {
            var product = await repo.All<Product>().FirstOrDefaultAsync(p => p.Id == id);

            if (product == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public async Task<ProductEditViewModel> GetProductById(Guid id)
        {
            var model = await repo.All<Product>()
                 .Include(p => p.Owner)
                 .Include(p => p.Categories)
                 .ThenInclude(c => c.Category)
                 .Where(p => p.Id == id)
                 .Select(p => new ProductEditViewModel
                 {
                     Id = p.Id,
                     Name = p.Name,
                     Description = p.Description,
                     ImageUrl = p.ImageUrl,
                     IsAvailable = p.IsAvailable == true ? "No" : "Yes",
                     IsApproved = p.IsApproved == true ? "Approved" : "Waiting for approval",
                     DateAdded = p.DateAdded,
                     PricePerDay = p.PricePerDay,
                     CategoriesAdded = p.Categories.Select(c => c.Category.Id).ToList()
                 })
                 .FirstOrDefaultAsync();

            if (model == null)
            {
                return null;
            }

            model.Categories = await repo.All<Category>()
                .Select(c => new CategoryViewModel
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToListAsync();

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
