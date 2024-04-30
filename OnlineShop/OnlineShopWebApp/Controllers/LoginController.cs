using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;
using System.Xml.Linq;

namespace OnlineShopWebApp.Controllers
{
	public class LoginController : Controller
	{
		private readonly IUsersManager usersManager;
		public LoginController(IUsersManager usersManager)
		{
			this.usersManager = usersManager;
		}

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
			var userAccount = usersManager.TryGetByName(login.Email);
			if (userAccount == null)
			{
				ModelState.AddModelError("", "Пользователь с таким именем не найден. Проверьте имя или зарегистрируйтесь.");
			}
			if (userAccount != null && userAccount.Password != login.Password)
			{
				ModelState.AddModelError("", "Не верный пароль");
			}
			if (!ModelState.IsValid)
			{
				return View("Login");
			}
			return RedirectToAction("Index", "Home");

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
				usersManager.Add(new User(registration.Email, registration.Password));
				return RedirectToAction("Index", "Home");
			}
			return View("Registration");
		}

	}
}

