using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using CookeBaseAuthApp.Models;

namespace CookeBaseAuthApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            LoginVM vm = new LoginVM();
            vm.UserId = "test";
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginVM vm)
        {
            if (!ModelState.IsValid)
                return View(vm);

            //After proper check with database

            //user principal
            //if (vm.UserId == vm.UserPassword) { 
            
            //}
            var claims = new List<Claim> {
             new Claim(ClaimTypes.Name,vm.UserId)
              
            };
            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

            // TempData["user"] = vm.UserId;
            return RedirectToAction("Index", "Home");

        }

        public async Task<IActionResult> SignOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}
