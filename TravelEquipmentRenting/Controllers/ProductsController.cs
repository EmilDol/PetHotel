using System.Security.Claims;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using TravelEquipmentRenting.Core.Contracts;
using TravelEquipmentRenting.Core.Models;

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
        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            string userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

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

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var model = await products.GetProductById(id);

            if (model == null)
            {
                return BadRequest();
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ProductEditViewModel model)
        {
            if (ModelState.IsValid == false)
            {
                return View(model);
            }

            if ((await products.Exists(model.Id)) == false)
            {
                ModelState.AddModelError("", "Product does not exist");
                return View(model);
            }

            await products.Edit(model);

            return RedirectToAction(nameof(MyProducts));
        }
    }
}
