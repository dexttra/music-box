using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class RolesController : Controller
	{
		private readonly IRolesStorage rolesStorage;

		public RolesController(IProductsStorage productsStorage)
		{
			this.rolesStorage = rolesStorage;
		}

		public IActionResult AddRole()
		{
			return View();
		}

		[HttpPost]
		public IActionResult AddRole(Role role)
		{
			if (rolesStorage.TryGetByName(role.Name) is not null)
			{
				ModelState.AddModelError("Name", "Такая роль уже существует");
			}
			if (ModelState.IsValid)
			{
				rolesStorage.AddRole(role);
				return RedirectToAction("Roles");
			}
			return View(role);
		}
		public IActionResult RemoveRole(string roleName)
		{
			rolesStorage.RemoveRole(roleName);
			return RedirectToAction("Roles");
		}
	}
}
