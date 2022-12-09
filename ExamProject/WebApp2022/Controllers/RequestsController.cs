using System.Security.Claims;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using WebApp2022.Core.Contracts;

namespace WebApp2022.Controllers
{
    [Authorize]
    public class RequestsController : Controller
    {
        private readonly IRequestsService requestsService;
        private readonly IAnnouncementService announcementService;
        private readonly IPetService petService;

        public RequestsController(IRequestsService requestsService, IAnnouncementService announcementService, IPetService petService)
        {
            this.announcementService = announcementService;
            this.requestsService = requestsService;
            this.petService = petService;
        }

        [HttpPost]
        public async Task<IActionResult> Add(Guid id)
        {
            string userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

            var petId = await announcementService.GetPetId(id);
            if (!(await petService.Exists(petId)))
            {
                return RedirectToAction(nameof(AnnouncementsController.Index), "Announcements");
            }
            if ((await petService.Owns(petId, userId)) == true)
            {
                return RedirectToAction(nameof(AnnouncementsController.Index), "Announcements");
            }
            if (await requestsService.Exists(id, userId))
            {
                return RedirectToAction(nameof(AnnouncementsController.Index), "Announcements");
            }

            await requestsService.Add(id, userId);

            return RedirectToAction(nameof(AnnouncementsController.Index), "Announcements");
        }

        [HttpGet]
        public async Task<IActionResult> Index(Guid id)
        {
            string userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

            var petId = await announcementService.GetPetId(id);
            if (!(await petService.Exists(petId)))
            {
                return RedirectToAction(nameof(AnnouncementsController.Index), "Announcements");
            }
            if ((await petService.Owns(petId, userId)) == false)
            {
                return RedirectToAction(nameof(AnnouncementsController.Index), "Announcements");
            }
            if (!await announcementService.Exists(id))
            {
                return RedirectToAction(nameof(AnnouncementsController.Index), "Announcements");
            }

            var model = await requestsService.All(id);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Reject(Guid id)
        {
            string userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            if (await requestsService.Exists(id, userId))
            {
                return RedirectToAction(nameof(RequestsController.Index), "Announcements");
            }

            var annId = await requestsService.GetAnnouncementId(id);
            await requestsService.Reject(id);

            return RedirectToAction(nameof(RequestsController.Index), "Requests", new {id = annId});
        }

        [HttpGet]
        public async Task<IActionResult> Accept(Guid id)
        {
            string userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            if (await requestsService.Exists(id, userId))
            {
                return RedirectToAction(nameof(RequestsController.Index), "Announcements");
            }

            var annId = await requestsService.GetAnnouncementId(id);
            await requestsService.Accept(id);

            return RedirectToAction(nameof(AnnouncementsController.Mine), "Announcements");
        }
    }
}
