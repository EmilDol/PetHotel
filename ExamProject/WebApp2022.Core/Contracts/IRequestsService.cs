using WebApp2022.Core.Models.Requests;

namespace WebApp2022.Core.Contracts
{
    public interface IRequestsService
    {
        Task Add(Guid annId, string userId);
        Task<List<RequestsAllViewModel>> All(Guid annId);
        Task<bool> Exists(Guid id, string userId);
        Task Reject(Guid id);
        Task<Guid> GetAnnouncementId(Guid id);
    }
}
