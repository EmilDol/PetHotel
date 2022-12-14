using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using WebApp2022.Core.Contracts.Administration;

namespace WebApp2022.Areas.Administration.Controllers
{
    [Area(nameof(Administration))]
    [Authorize(Roles = "Admin")]
    public class PetsController : Controller
    {
        private readonly IApproveService approveService;

        public PetsController(IApproveService approveService)
        {
            this.approveService = approveService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await approveService.GetPets();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Approve(Guid id)
        {
            if (!await approveService.ExistPet(id))
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }

            await approveService.ApprovePet(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Reject(Guid id)
        {
            if (!await approveService.ExistPet(id))
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }

            await approveService.RejectPet(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
