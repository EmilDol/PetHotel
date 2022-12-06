using Microsoft.AspNetCore.Mvc;

namespace WebApp2022.Controllers
{
    public class RequestsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
