namespace OnlineShopWebApp.Models
{
    public interface IOrdersStorage
    {
        void Add(Order order);
        
        List<Order> GetAll();
		Order TryGetById(int orderId);
	}
}