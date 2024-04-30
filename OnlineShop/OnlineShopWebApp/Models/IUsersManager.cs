
namespace OnlineShopWebApp.Models
{
	public interface IUsersManager
	{
		void Add(User user);
		List<User> GetAll();
		User TryGetByName(string name);
	}
}