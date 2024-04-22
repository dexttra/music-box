
namespace OnlineShopWebApp.Models
{
	public class RolesInMemoryStorage : IRolesStorage
	{
		private readonly List<Role> roles = new List<Role>();
		public void AddRole(Role role)
		{
			roles.Add(role);
		}

		public void RemoveRole(string name) 
		{
			roles.RemoveAll(role => role.Name == name);
		}

		public List<Role> GetAll()
		{
			return roles;
		}

		public Role TryGetByName(string name)
		{
			return roles.FirstOrDefault(role => role.Name == name);
		}
	}
}
