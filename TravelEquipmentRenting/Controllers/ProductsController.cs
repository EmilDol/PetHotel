using System.Security.Claims;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using TravelEquipmentRenting.Core.Contracts;

namespace TravelEquipmentRenting.Controllers
{
    [Authorize]
    public class ProductsController : Controller
    {
        private readonly IProductService products;

        public ProductsController(IProductService products)
        {
            this.products = products;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            string userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

            if (userId == null)
            {
                return BadRequest();
            }

            var model = await products.AllAsync(userId);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> MyProducts()
        {
            string userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

            if (userId == null)
            {
                return BadRequest();
            }

            var model = await products.Mine(userId);

            return View(model);
        }
    }
}
