using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult SignIn(Login login)
		{
			return View("Index");
		}

		public IActionResult SignUp()
		{
			return View();
		}
	}
}
