using Microsoft.EntityFrameworkCore;

using WebApp2022.Core.Contracts;
using WebApp2022.Core.Models.Requests;
using WebApp2022.Infrastructure.Data;
using WebApp2022.Infrastructure.Data.Common;

namespace WebApp2022.Core.Services
{
    public class RequestsService : IRequestsService
    {

        private readonly IRepository repository;

        public RequestsService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task Accept(Guid id)
        {
            var model = await repository.All<Request>()
                .Include(r => r.Announcement)
                .FirstOrDefaultAsync(r => r.Id == id);

            if (model == null)
            {
                return;
            }

            model.IsConfirmed = true;
            var idsToRemove = await repository.All<Request>()
                .Where(r => r.AnnouncementId == model.AnnouncementId && r.Id != id)
                .Select(r => r.Id)
                .ToListAsync();

            var announcement = await repository.All<Announcement>()
                .FirstAsync(a => a.Id == model.AnnouncementId);

            announcement.IsAvailable = false;

            foreach (var idRemove in idsToRemove)
            {
                await repository.DeleteAsync<Request>(idRemove);
            }

            await repository.SaveChangesAsync();
        }

        public async Task Add(Guid annId, string userId)
        {
            var request = new Request
            {
                AnnouncementId = annId,
                BabysitterId = userId,
                IsConfirmed = false,
                Id = Guid.NewGuid()
            };

            await repository.AddAsync(request);
            await repository.SaveChangesAsync();
        }

        public async Task<List<RequestsAllViewModel>> All(Guid annId)
        {
            var model = await repository.All<Request>()
                .Where(r => r.AnnouncementId == annId)
                .Include(r => r.Announcement)
                .ThenInclude(a => a.Pet)
                .ThenInclude(p => p.Owner)
                .Select(r => new RequestsAllViewModel
                {
                    Id = r.Id,
                    OwnerName = $"{r.Announcement.Pet.Owner.FirstName} {r.Announcement.Pet.Owner.LastName}",
                    OwnerPhone = r.Announcement.Pet.Owner.PhoneNumber,
                    OwnerEmail = r.Announcement.Pet.Owner.Email
                })
                .ToListAsync();

            return model;
        }

        public async Task<bool> Exists(Guid id, string userId)
        {
            var model = await repository.All<Announcement>()
                .Include(a => a.Requests)
                .Where(a => a.Id == id)
                .Select(a => a.Requests.Any(r => r.BabysitterId == userId))
                .FirstOrDefaultAsync();

            return model;
        }

        public async Task<Guid> GetAnnouncementId(Guid id)
        {
            var model = await repository.All<Request>()
                .FirstOrDefaultAsync(r => r.Id == id);

            if (model == null)
            {
                return Guid.Empty;
            }

            return model.AnnouncementId;
        }

        public async Task Reject(Guid id)
        {
            var isConfirmed = await repository.All<Request>()
                .Where(r => r.Id == id)
                .Select(r => r.IsConfirmed)
                .FirstAsync();
            if (isConfirmed)
            {
                return;
            }
            await repository.DeleteAsync<Request>(id);
            await repository.SaveChangesAsync();
        }
    }
}
