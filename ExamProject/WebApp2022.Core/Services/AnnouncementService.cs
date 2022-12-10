using Microsoft.EntityFrameworkCore;

using WebApp2022.Core.Contracts;
using WebApp2022.Core.Models.Announcements;
using WebApp2022.Infrastructure.Data;
using WebApp2022.Infrastructure.Data.Common;

namespace WebApp2022.Core.Services
{
    public class AnnouncementService : IAnnouncementService
    {
        private readonly IRepository repository;

        public AnnouncementService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task Add(AnnouncementAddViewModel model, string userId)
        {
            var pet = await repository.All<Pet>().FirstOrDefaultAsync(p => p.Id == model.PetId);

            if (pet == null && !pet.IsApproved && pet.OwnerId != userId)
            {
                return;
            }

            pet.NeedBabysitting = true;
            pet.IsBabysittedNow = false;

            var announcement = new Announcement
            {
                OfferedPaying = model.OfferedPaying,
                IsAvailable = true,
                DayEnding = model.DayEnding,
                DayStarting = model.DayStarting,
                Id = Guid.NewGuid(),
                PetId = pet.Id
            };

            await repository.AddAsync(announcement);
            await repository.SaveChangesAsync();
        }

        public async Task<List<AnnouncementAllViewModel>> All(string userId)
        {
            var model = await repository
                .All<Announcement>()
                .Include(p => p.Pet)
                .OrderBy(a => a.DayStarting)
                .Where(p => p.Pet.OwnerId != userId &&
                    p.Pet.IsApproved == true &&
                    p.Pet.IsBabysittedNow == false &&
                    p.Pet.NeedBabysitting == true
                    &&
                    p.Requests.All(a => a.IsConfirmed == false)
                    )
                .Select(p => new AnnouncementAllViewModel
                {
                    Id = p.Id,
                    OwnerId = p.Pet.OwnerId,
                    Name = p.Pet.Name,
                    Description = p.Pet.Description,
                    ImageUrl = p.Pet.ImageUrl,
                    Heigth = p.Pet.Heigth,
                    Weigth = p.Pet.Heigth,
                    Type = p.Pet.Type.ToString(),
                    DateStartBabysitting = p.DayStarting.ToString("d"),
                    DateEndBabysitting = p.DayEnding.ToString("d"),
                    OwnerName = $"{p.Pet.Owner.FirstName} {p.Pet.Owner.LastName}"
                })
                .ToListAsync();

            return model;
        }

        public async Task<bool> BelongsTo(Guid id, string userId)
        {
            var model = await repository.All<Announcement>()
                .Include(a => a.Pet)
                .Where(a => a.Id == id)
                .Select(a => a.Pet.OwnerId)
                .FirstAsync();

            if (model == userId)
            {
                return true;
            }

            return false;
        }

        public async Task Delete(Guid id)
        {
            var requestIds = await repository.All<Request>()
                .Where(r => r.AnnouncementId == id)
                .Select(r => r.Id)
                .ToListAsync();
            foreach (var requestId in requestIds)
            {
                await repository.DeleteAsync<Request>(requestId);
            }
            await repository.DeleteAsync<Announcement>(id);

            await repository.SaveChangesAsync();
        }

        public async Task<bool> Exists(Guid id)
        {
            var model = await repository.All<Announcement>()
                .Where(p => p.Id == id)
                .FirstOrDefaultAsync();

            if (model == null)
            {
                return false;
            }
            return true;
        }

        public async Task<Guid> GetPetId(Guid id)
        {
            var petId = await repository.All<Announcement>()
                .Where(a => a.Id == id)
                .Select(a => a.PetId)
                .FirstOrDefaultAsync();

            return petId;
        }

        public async Task<bool> HasAnnouncement(Guid petId, DateTime dayStarting, DateTime dayEnding)
        {
            var pet = await repository.All<Pet>().Include(p => p.Announcements).FirstOrDefaultAsync(p => p.Id == petId);

            if (pet == null)
            {
                return true;
            }

            foreach (var item in pet.Announcements)
            {
                int itemEndParamStart = DateTime.Compare(item.DayEnding, dayStarting);
                int itemEndParamEnd = DateTime.Compare(item.DayEnding, dayEnding);
                int itemStartParamStart = DateTime.Compare(item.DayStarting, dayStarting);
                int itemStartParamEnd = DateTime.Compare(item.DayStarting, dayEnding);
                if (itemEndParamStart >= 0 && itemEndParamEnd <= 0)
                {
                    return true;
                }
                else if (itemStartParamStart >= 0 && itemStartParamEnd <= 0)
                {
                    return true;
                }
            }
            return false;
        }

        public async Task<List<AnnouncementMineViewModel>> Mine(string userId)
        {
            var announcements = await repository.All<Announcement>()
                .Include(a => a.Pet)
                .Where(a => a.Pet.OwnerId == userId)
                .Select(a => new AnnouncementMineViewModel
                {
                    DateEndBabysitting = a.DayEnding.ToString("d"),
                    DateStartBabysitting = a.DayStarting.ToString("d"),
                    ImageUrl = a.Pet.ImageUrl,
                    Id = a.Id,
                    Name = a.Pet.Name,
                    Price = a.OfferedPaying.ToString(),
                    IsAvailable = a.IsAvailable
                })
                .ToListAsync();

            return announcements;
        }

        public async Task<AnnouncementDetailsViewModel> GetDetailsById(Guid id)
        {
            var model = await repository.All<Announcement>()
                .Include(p => p.Pet)
                .Where(p => p.Pet.IsApproved == true &&
                    p.Pet.IsBabysittedNow == false &&
                    p.Pet.NeedBabysitting == true)
                .Include(p => p.Pet.Owner)
                .Select(p => new AnnouncementDetailsViewModel
                {
                    Id = p.Id,
                    PetId = p.Pet.Id,
                    Age = p.Pet.Age,
                    DateEndBabysitting = p.DayEnding.ToString("d"),
                    DateStartBabysitting = p.DayStarting.ToString("d"),
                    Description = p.Pet.Description,
                    Heigth = p.Pet.Heigth,
                    ImageUrl = p.Pet.ImageUrl,
                    Name = p.Pet.Name,
                    OwnerName = $"{p.Pet.Owner.FirstName} {p.Pet.Owner.LastName}",
                    Requirements = p.Pet.Requirements,
                    Weigth = p.Pet.Weigth,
                    Type = p.Pet.Type.ToString()
                })
                .FirstOrDefaultAsync(p => p.Id == id);

            return model;
        }
    }
}
