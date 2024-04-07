using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Controllers
{
    public class LoginController : Controller
    {

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignIn(Login login)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Login");
        }

        [HttpPost]
        public IActionResult SignUp(Registration registration)
        {
            if (registration.Email == registration.Password) 
            {
                ModelState.AddModelError("", "Логин и пароль не должны совпадать");
            }
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Registration");
        }
    }
}
