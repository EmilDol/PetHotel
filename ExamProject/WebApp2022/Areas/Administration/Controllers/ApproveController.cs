using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApp2022.Areas.Administration.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ApproveController : Controller
    {
        [HttpGet]
        public IActionResult Towns()
        {
            return View();
        }
    }
}
