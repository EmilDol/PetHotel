using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using WebApp2022.Core.Contracts.Administration;

namespace WebApp2022.Areas.Administration.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area(nameof(Administration))]
    public class TownsController : Controller
    {
        private readonly IApproveService approveService;

        public TownsController(IApproveService approveService)
        {
            this.approveService = approveService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await approveService.GetTowns();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Approve(Guid id)
        {
            if (!await approveService.ExistTown(id))
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }

            await approveService.ApproveTown(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Reject(Guid id)
        {
            if (!await approveService.ExistTown(id))
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }

            await approveService.RejectTown(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
