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


		public IActionResult ChangePassword(string name)
		{
			var changeUserPassword = new ChangeUserPassword();
			changeUserPassword.UserName = name;

			return View(changeUserPassword);
		}

		[HttpPost]
		public IActionResult ChangePassword(ChangeUserPassword changeUserPassword)
		{

			if (changeUserPassword.UserName == changeUserPassword.Password)
			{
				ModelState.AddModelError("", "Логин и пароль не должны совпадать");
			}
			if (ModelState.IsValid)
			{
				usersManager.ChangePassword(changeUserPassword.UserName, changeUserPassword.Password);
				return RedirectToAction("Index");
			}
			return View();

		}
	}
}
