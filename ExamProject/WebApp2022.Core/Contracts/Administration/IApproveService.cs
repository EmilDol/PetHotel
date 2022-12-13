using WebApp2022.Core.Models.Admin.Towns;

namespace WebApp2022.Core.Contracts.Administration
{
    public interface IApproveService
    {
        Task<List<AllTownsApproveViewModel>> GetTowns();
        Task<bool> ExistTown(Guid id);
        Task ApproveTown(Guid id);
        Task RejectTown(Guid id);
    }
}
