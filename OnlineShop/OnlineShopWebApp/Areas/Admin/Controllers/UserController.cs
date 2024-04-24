using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Areas.Admin.Controllers
{
	public class UserController : Controller
	{
		public IActionResult Users()
		{
			return View();
		}
	}
}
