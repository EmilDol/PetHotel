using Microsoft.EntityFrameworkCore;

using WebApp2022.Core.Contracts;
using WebApp2022.Core.Models;
using WebApp2022.Infrastructure.Data;
using WebApp2022.Infrastructure.Data.Common;
using WebApp2022.Infrastructure.Data.Enums;

namespace WebApp2022.Core.Services
{
    public class PetService : IPetService
    {
        private readonly IRepository repository;

        public PetService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task Add(PetAddViewModel model, string userId)
        {
            var pet = new Pet
            {
                Id = model.Id,
                Age = model.Age,
                Description = model.Description,
                Heigth = model.Heigth,
                ImageUrl = model.ImageUrl,
                Name = model.Name,
                Requirements = model.Requirements,
                Weigth = model.Weigth,
                OwnerId = userId,
                DateAdded = DateTime.UtcNow,
                IsApproved = false,
                IsBabysittedNow = false,
                NeedBabysitting = false
            };
            AnimalType type;

            bool result = Enum.TryParse(model.Type, out type);

            if (!result)
            {
                return;
            }

            pet.Type = type;
            await repository.AddAsync(pet);

            await repository.SaveChangesAsync();
        }

        public async Task<List<PetAllViewModel>> All(string userId)
        {
            var model = await repository
                .All<Pet>()
                .Include(p => p.Announcement)
                .Where(p => p.OwnerId != userId &&
                    p.IsApproved == true &&
                    p.IsBabysittedNow == false &&
                    p.NeedBabysitting == true)
                .Select(p => new PetAllViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    ImageUrl = p.ImageUrl,
                    Heigth = p.Heigth,
                    Weigth = p.Heigth,
                    Type = p.Type.ToString(),
                    DateStartBabysitting = p.Announcement.DayStarting.ToString("d"),
                    DateEndBabysitting = p.Announcement.DayEnding.ToString("d"),
                    OwnerName = $"{p.Owner.FirstName} {p.Owner.LastName}"
                })
                .ToListAsync();

            return model;
        }

        public async Task Edit(PetEditViewModel model)
        {
            var pet = await repository.All<Pet>().FirstOrDefaultAsync(p => p.Id == model.Id);

            if (pet == null)
            {
                return;
            }

            AnimalType type;

            bool result = Enum.TryParse(model.Type, out type);

            if (!result)
            {
                return;
            }

            pet.Type = type;

            pet.Name = model.Name;
            pet.Description = model.Description;
            pet.IsApproved = false;
            pet.Age = model.Age;
            pet.Requirements = model.Requirements;
            pet.Heigth = model.Heigth;
            pet.Weigth = model.Weigth;
            pet.ImageUrl = model.ImageUrl;
            pet.Type = type;

            await repository.SaveChangesAsync();
        }

        public async Task<bool> Exists(Guid id)
        {
            var model = await repository.All<Pet>().FirstOrDefaultAsync(p => p.Id == id);

            if (model == null)
            {
                return false;
            }
            return true;
        }

        public async Task<PetDetailsViewModel> GetDetailsById(Guid id)
        {
            var model = await repository.All<Pet>()
                .Where(p => p.IsApproved == true &&
                    p.IsBabysittedNow == false &&
                    p.NeedBabysitting == true)
                .Include(p => p.Owner)
                .Include(p => p.Announcement)
                .Select(p => new PetDetailsViewModel
                {
                    Id = p.Id,
                    Age = p.Age,
                    DateEndBabysitting = p.Announcement.DayEnding.ToString("d"),
                    DateStartBabysitting = p.Announcement.DayStarting.ToString("d"),
                    Description = p.Description,
                    Heigth = p.Heigth,
                    ImageUrl = p.ImageUrl,
                    Name = p.Name,
                    OwnerName = $"{p.Owner.FirstName} {p.Owner.LastName}",
                    Requirements = p.Requirements,
                    Weigth = p.Weigth,
                    Type = p.Type.ToString()
                })
                .FirstOrDefaultAsync(p => p.Id == id);

            return model;
        }

        public async Task<PetEditViewModel> GetPetToEditById(Guid id)
        {
            var model = await repository.All<Pet>()
                .Select(p => new PetEditViewModel
                {
                    Id = p.Id,
                    Heigth = p.Heigth,
                    Age = p.Age,
                    Name = p.Name,
                    Description = p.Description,
                    ImageUrl = p.ImageUrl,
                    Requirements = p.Requirements,
                    Weigth = p.Weigth,
                    Type = p.Type.ToString()
                })
                .FirstOrDefaultAsync(p => p.Id == id);

            return model;
        }

        public async Task<bool> IsApproved(Guid id)
        {
            var model = await repository.All<Pet>().FirstOrDefaultAsync(p => p.Id == id);

            return model?.IsApproved ?? false;
        }

        public async Task<List<PetMineViewModel>> Mine(string userId)
        {
            var model = await repository.All<Pet>()
                .Where(p => p.OwnerId == userId)
                .Select(p => new PetMineViewModel
                {
                    Description = p.Description,
                    Name = p.Name,
                    Id = p.Id,
                    ImageUrl = p.ImageUrl,
                    Type = p.Type.ToString(),
                    Requirements = p.Requirements,
                    IsApproved = p.IsApproved ? "Approved" : "Waiting approval"
                })
                .ToListAsync();

            return model;
        }

        public async Task<bool> Owns(Guid petId, string userId)
        {
            var model = await repository.All<Pet>().FirstOrDefaultAsync(p => p.Id == petId);

            if (model.OwnerId == userId)
            {
                return true;
            }

            return false;
        }
    }
}
