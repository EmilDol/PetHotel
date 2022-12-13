using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApp2022.Areas.Administration.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area(nameof(Administration))]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
