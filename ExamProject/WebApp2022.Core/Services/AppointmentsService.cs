using Microsoft.EntityFrameworkCore;

using WebApp2022.Core.Contracts;
using WebApp2022.Core.Models.Appointments;
using WebApp2022.Infrastructure.Data;
using WebApp2022.Infrastructure.Data.Common;

namespace WebApp2022.Core.Services
{
    public class AppointmentsService : IAppointmentsService
    {
        private readonly IRepository repository;

        public AppointmentsService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task<List<AppointmentAllViewModel>> All(string userId)
        { 
            var model = await repository.All<Announcement>()
                .Include(a => a.Pet)
                .ThenInclude(p => p.Owner)
                .Include(a => a.Requests)
                .ThenInclude(r => r.Babysitter)
                .Where(a => a.IsAvailable == false &&
                a.Requests.Count == 1 &&
                a.Requests.All(r => r.BabysitterId == userId) &&
                a.Requests.All(r => r.IsConfirmed == true))
                .OrderBy(a => a.DayStarting)
                .Select(a => new AppointmentAllViewModel
                {
                    EndDate = a.DayEnding.ToString("d"),
                    StartDate = a.DayStarting.ToString("d"),
                    ImageUrl = a.Pet.ImageUrl,
                    OwnerName = $"{a.Pet.Owner.FirstName} {a.Pet.Owner.LastName}",
                    OwnerPhone = a.Pet.Owner.PhoneNumber,
                    PetName = a.Pet.Name,
                    PetType = a.Pet.Type.ToString(),
                    OwnerId = a.Pet.OwnerId
                })
                .ToListAsync();

            return model;
        }
    }
}
