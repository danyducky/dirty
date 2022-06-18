using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Openskill.Domain.Entities;
using Openskill.Helpers.Enums;
using Openskill.Helpers.Filters;
using Openskill.Models.Auth;

namespace Openskill.Controllers
{
    public class AuthController : Controller
    {
        private readonly SignInManager<User> signInManager;
        private readonly UserManager<User> userManager;

        public AuthController(SignInManager<User> signInManager, UserManager<User> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        [AuthMenu(AuthItem.Login)]
        [HttpGet]
        public IActionResult Index(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;

            if (User.Identity.IsAuthenticated)
            {
                if (Url.IsLocalUrl(ViewBag.ReturnUrl))
                    return Redirect(ViewBag.ReturnUrl);

                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [AuthMenu(AuthItem.Login)]
        [HttpPost]
        public async Task<IActionResult> Login(AuthLoginModel model, string? returnUrl = null)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }

            returnUrl ??= Url.Content("~/");

            var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, true, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                return LocalRedirect(returnUrl);
            }

            ModelState.AddModelError("Invalid", "Неверные данные");
            return View("Index", model);
        }

        [AuthMenu(AuthItem.Register)]
        [HttpGet("register")]
        public IActionResult Register(string returnUrl)
        {
            ViewBag.ReturnUrl ??= Url.Content("~/");

            if (User.Identity.IsAuthenticated)
            {
                if (Url.IsLocalUrl(ViewBag.ReturnUrl))
                    return Redirect(ViewBag.ReturnUrl);

                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [AuthMenu(AuthItem.Register)]
        [HttpPost("register")]
        public async Task<IActionResult> Register(AuthRegisterModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new User
            {
                FirstName = model.Firstname,
                LastName = model.Lastname,
                UserName = model.Email,
                Email = model.Email
            };

            var result = await userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                await signInManager.SignInAsync(user, isPersistent: false);
                return LocalRedirect(returnUrl);
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            return View();
        }

        [HttpGet("logout")]
        public async Task<IActionResult> Logout(string returnUrl)
        {
            await signInManager.SignOutAsync();
            if (returnUrl != null)
            {
                return LocalRedirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}
