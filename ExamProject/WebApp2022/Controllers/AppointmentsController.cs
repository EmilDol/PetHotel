using Microsoft.AspNetCore.Mvc;

namespace WebApp2022.Controllers
{
    public class AppointmentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
