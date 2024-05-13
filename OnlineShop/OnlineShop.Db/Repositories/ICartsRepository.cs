using OnlineShop.Db.Models;
using OnlineShopWebApp.Models;

namespace OnlineShop.Db.Repositories
{
    public interface ICartsRepository
    {
        void Add(Guid userId, Product product);
        Cart TryGetByUserId(Guid userId);
        void RemoveItem(Guid userId, Guid productId);
        void ClearAll(Guid userId);
    }
}