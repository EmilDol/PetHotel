using WebApp2022.Core.Models;

namespace WebApp2022.Core.Contracts
{
    public interface ITownService
    {
        Task<List<TownViewModel>> GetTowns();
        Task Add(string name);
    }
}
