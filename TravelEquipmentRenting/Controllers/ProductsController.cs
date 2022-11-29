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

            var model = await products.All(userId);

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
            if ((await products.Exists(id)) == false)
            {
                return BadRequest();
            }

            var model = await products.GetProductToEditById(id);

            if (model == null)
            {
                return BadRequest();
            }

            string userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            if (userId == null)
            {
                return Unauthorized();
            }

            if ((await products.BelongsTo(userId, id)) == false)
            {
                return Unauthorized();
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

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(Guid id)
        {
            if ((await products.Exists(id)) == false)
            {
                return BadRequest();
            }
            
            if ((await products.IsApproved(id)) == false)
            {
                return Unauthorized();
            }

            var model = await products.GetProductDetailsById(id);

            string userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

            if (await products.BelongsTo(userId, id))
            {
                return Unauthorized();
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new ProductAddViewModel();
            model.Categories = await products.GetAllCategories();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProductAddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            string userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            await products.Add(model, userId);

            return RedirectToAction(nameof(ProductsController.MyProducts));
        }
    }
}
