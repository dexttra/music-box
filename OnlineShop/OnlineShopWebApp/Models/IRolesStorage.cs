namespace OnlineShopWebApp.Models
{
    public interface IRolesStorage
    {
		Role TryGetByName(string name);
		List<Role> GetAll();
		void AddRole(Role role);
		void RemoveRole(string name);
	}
}