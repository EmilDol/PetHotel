using System.Security.Claims;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using WebApp2022.Core.Contracts;
using WebApp2022.Core.Models.Pets;

namespace WebApp2022.Controllers
{
    [Authorize]
    public class PetsController : Controller
    {
        private readonly IPetService petService;

        public PetsController(IPetService petService)
        {
            this.petService = petService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            string userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

            if (userId == null)
            {
                return BadRequest();
            }

            var model = await petService.Mine(userId);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            if ((await petService.Exists(id)) == false)
            {
                return BadRequest();
            }

            var model = await petService.GetPetToEditById(id);

            if (model == null)
            {
                return BadRequest();
            }

            string userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            if (userId == null)
            {
                return Unauthorized();
            }

            if ((await petService.Owns(id, userId)) == false)
            {
                return Unauthorized();
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(PetEditViewModel model)
        {
            if (ModelState.IsValid == false)
            {
                return View(model);
            }

            if ((await petService.Exists(model.Id)) == false)
            {
                ModelState.AddModelError("", "Product does not exist");
                return View(model);
            }

            string userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            if ((await petService.Owns(model.Id, userId)) == false)
            {
                return Unauthorized();
            }

            await petService.Edit(model);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(Guid id)
        {
            if ((await petService.Exists(id)) == false)
            {
                return BadRequest();
            }

            if ((await petService.IsApproved(id)) == false)
            {
                return Unauthorized();
            }
            
            string userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            if (await petService.Owns(id, userId))
            {
                return Unauthorized();
            }

            var model = await petService.GetDetailsById(id);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new PetAddViewModel();
            model.Id = Guid.NewGuid();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(PetAddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            string userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            await petService.Add(model, userId);

            return RedirectToAction(nameof(PetsController.Index));
        }
    }
}
