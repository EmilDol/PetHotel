using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using WebApp2022.Core.Contracts;

namespace WebApp2022.Controllers
{
    [Authorize]
    public class TownsController : Controller
    {
        private readonly ITownService townService;

        public TownsController(ITownService townService)
        {
            this.townService = townService;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(string name)
        {
            await townService.Add(name);
            return RedirectToAction(nameof(AccountController.Register), "Account");
        }
    }
}
