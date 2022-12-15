using System.Security.Claims;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using WebApp2022.Core.Contracts;
using WebApp2022.Core.Models.Announcements;

namespace WebApp2022.Controllers
{
    [Authorize]
    public class AnnouncementsController : Controller
    {
        private readonly IAnnouncementService announcementService;
        private readonly IPetService petService;

        public AnnouncementsController(IAnnouncementService announcementService, IPetService petService)
        {
            this.announcementService = announcementService;
            this.petService = petService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            string userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

            var model = await announcementService.All(userId);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Mine()
        {
            string userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

            var model = await announcementService.Mine(userId);

            return View(model);
        }

        [HttpGet]
        public IActionResult Add(Guid id)
        {
            var model = new AnnouncementAddViewModel { PetId = id};

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AnnouncementAddViewModel model)
        {
            int result = DateTime.Compare(model.DayStarting, model.DayEnding);

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (result >= 0)
            {
                ModelState.AddModelError("", "End date must be after the start date!");
                return View(model);
            }

            if ((await petService.IsApproved(model.PetId)) == false)
            {
                return RedirectToAction(nameof(Index));
            }

            if ((await announcementService.HasAnnouncement(model.PetId, model.DayStarting, model.DayEnding)) == true)
            {
                return RedirectToAction(nameof(Index));
            }

            string userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            await announcementService.Add(model, userId);

            return RedirectToAction(nameof(PetsController.Index), "Pets");
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            if (!await announcementService.Exists(id))
            {
                return RedirectToAction(nameof(Mine));
            }

            string userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            if (!await announcementService.BelongsTo(id, userId))
            {
                return RedirectToAction(nameof(Mine));
            }
            
            await announcementService.Delete(id);
            return RedirectToAction(nameof(Mine));
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(Guid id)
        {
            if ((await announcementService.Exists(id)) == false)
            {
                return BadRequest();
            }

            var model = await announcementService.GetDetailsById(id);

            return View(model);
        }

    }
}
