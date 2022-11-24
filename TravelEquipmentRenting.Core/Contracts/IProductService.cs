using TravelEquipmentRenting.Core.Models;

namespace TravelEquipmentRenting.Core.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductAllViewModel>> AllAsync(string userId);
        Task<IEnumerable<ProductMineViewModel>> Mine(string userId);
    }
}
