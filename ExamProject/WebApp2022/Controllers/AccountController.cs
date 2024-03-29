﻿using System.Security.Claims;

using Ganss.Xss;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using WebApp2022.Core.Contracts;
using WebApp2022.Core.Models.Account;
using WebApp2022.Core.Models.Comments;
using WebApp2022.Infrastructure.Data;
using WebApp2022.Models;

namespace WebApp2022.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ITownService townService;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IAccountService accountService;

        public AccountController(
            UserManager<ApplicationUser> _userManager,
            SignInManager<ApplicationUser> _signInManager,
            ITownService townService,
            IAccountService accountService)
        {
            userManager = _userManager;
            signInManager = _signInManager;
            this.townService = townService;
            this.accountService = accountService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Register()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }

            var model = new RegisterViewModel();
            model.Towns = await townService.GetTowns();

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var sanitizer = new HtmlSanitizer();

            var user = new ApplicationUser()
            {
                Email = sanitizer.Sanitize(model.Email),
                UserName = sanitizer.Sanitize(model.UserName),
                FirstName = sanitizer.Sanitize(model.FirstName),
                LastName = sanitizer.Sanitize(model.LastName),
                PhoneNumber = sanitizer.Sanitize(model.PhoneNumber),
                TownId = Guid.Parse(model.Town)
            };

            var result = await userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(user, "User");
                return RedirectToAction(nameof(AccountController.Login), "Account");
            }

            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }

            var model = new LoginViewModel();

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await userManager.FindByEmailAsync(model.Email);

            if (user != null)
            {
                var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);

                if (result.Succeeded)
                {
                    return RedirectToAction(nameof(HomeController.Index), "Home");
                }
            }

            ModelState.AddModelError("", "Invalid login");

            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        public async Task<IActionResult> Edit()
        {
            string userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

            var user = await accountService.GetUserToEdit(userId);
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditAccountViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            string userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            await accountService.Edit(model, userId);
            return RedirectToAction(nameof(AnnouncementsController.Index), "Announcements");
        }

        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            if (!await accountService.Exists(id))
            {
                return RedirectToAction(nameof(AnnouncementsController.Index), "Announcements");
            }

            var model = await accountService.Details(id);
            return View(model);
        }


        public async Task<IActionResult> AddComment(CommentAddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(Details), new { id = model.ReceiverId });
            }

            string userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            if (model.ReceiverId == userId)
            {
                return Unauthorized();
            }

            await accountService.AddComment(model, userId);
            return RedirectToAction(nameof(Details), new { id = model.ReceiverId });
        }
    }
}
