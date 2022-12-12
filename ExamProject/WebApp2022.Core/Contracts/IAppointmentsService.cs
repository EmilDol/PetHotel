using WebApp2022.Core.Models.Appointments;

namespace WebApp2022.Core.Contracts
{
    public interface IAppointmentsService
    {
        Task<List<AppointmentAllViewModel>> All(string userId);
    }
}
