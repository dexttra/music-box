using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class UserController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
