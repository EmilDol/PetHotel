using TravelEquipmentRenting.Core.Models;

namespace TravelEquipmentRenting.Core.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductAllViewModel>> AllAsync(string userId);
        Task<IEnumerable<ProductMineViewModel>> Mine(string userId);
        Task<ProductEditViewModel> GetProductById(Guid id);
        Task<bool> Exists(Guid id);
        Task Edit(ProductEditViewModel model);
    }
}
