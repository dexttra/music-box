using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class RoleController : Controller
	{
		private readonly IRolesStorage rolesStorage;

		public RoleController(IRolesStorage rolesStorage)
		{
			this.rolesStorage = rolesStorage;
		}

		public IActionResult Index()
		{
			var roles = rolesStorage.GetAll();
			return View(roles);
		}
		public IActionResult Add()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Add(Role role)
		{
			if (rolesStorage.TryGetByName(role.Name) is not null)
			{
				ModelState.AddModelError("Name", "Такая роль уже существует");
			}
			if (ModelState.IsValid)
			{
				rolesStorage.AddRole(role);
				return RedirectToAction("Index");
			}
			return View(role);
		}
		public IActionResult RemoveRole(string roleName)
		{
			rolesStorage.RemoveRole(roleName);
			return RedirectToAction("Index");
		}
	}
}
