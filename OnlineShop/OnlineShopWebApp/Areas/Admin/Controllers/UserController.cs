using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class UserController : Controller
	{
		private readonly IUsersManager usersManager;

		public UserController(IUsersManager usersManager)
		{
			this.usersManager = usersManager;
		}

		public IActionResult Index()
		{
			var users = usersManager.GetAll();
			return View(users);
		}


		public IActionResult Details(string name)
		{
			var user = usersManager.TryGetByName(name);
			return View(user);
		}
	}
}
