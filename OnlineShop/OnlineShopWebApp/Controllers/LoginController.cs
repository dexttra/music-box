using Microsoft.AspNetCore.Mvc;

namespace OnlineShopWebApp.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult SignIn(string email, string password)
		{
			return View("Index");
		}

		public IActionResult SignUp()
		{
			return View();
		}
	}
}
