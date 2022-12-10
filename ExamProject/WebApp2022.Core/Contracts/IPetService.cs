using WebApp2022.Core.Models.Announcements;
using WebApp2022.Core.Models.Pets;

namespace WebApp2022.Core.Contracts
{
    public interface IPetService
    {
        Task<List<PetMineViewModel>> Mine(string userId);

        Task<bool> Exists(Guid id);

        Task<bool> Owns(Guid petId, string userId);

        Task<PetEditViewModel> GetPetToEditById(Guid id);

        Task Edit(PetEditViewModel model);

        Task<bool> IsApproved(Guid id);

        Task Add(PetAddViewModel model, string userId);
    }
}
