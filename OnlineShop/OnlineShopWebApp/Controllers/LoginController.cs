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
			return View("Login");
		}

		[HttpPost]
		public IActionResult SignUp(string email, string password)
		{
			return View("Registration");
		}
	}
}
