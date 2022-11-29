using TravelEquipmentRenting.Core.Models;

namespace TravelEquipmentRenting.Core.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductAllViewModel>> All(string userId);
        Task<IEnumerable<ProductMineViewModel>> Mine(string userId);
        Task<ProductEditViewModel> GetProductToEditById(Guid id);
        Task<bool> Exists(Guid id);
        Task Edit(ProductEditViewModel model);
        Task<bool> BelongsTo(string userId, Guid id);
        Task<ProductDetailsViewModel> GetProductDetailsById(Guid id);
        Task<bool> IsApproved(Guid id);
        Task Add(ProductAddViewModel model, string userId);
        Task<List<CategoryViewModel>> GetAllCategories();
    }
}
