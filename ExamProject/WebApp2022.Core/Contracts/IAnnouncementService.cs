using WebApp2022.Core.Models.Announcements;

namespace WebApp2022.Core.Contracts
{
    public interface IAnnouncementService
    {
        Task<List<AnnouncementAllViewModel>> All(string userId);
        Task Add(AnnouncementAddViewModel model, string userId);
        Task<bool> HasAnnouncement(Guid petId, DateTime dayStarting, DateTime dayEnding);
        Task<List<AnnouncementMineViewModel>> Mine(string userId);
        Task<Guid> GetPetId(Guid id);
        Task<bool> Exists(Guid id);
        Task<bool> BelongsTo(Guid id, string userId);
        Task Delete(Guid id);
    }
}
