using Microsoft.AspNetCore.Mvc;

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
		public IActionResult SignIn(string email, string password)
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
