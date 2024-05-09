namespace OnlineShopWebApp.Models
{
    public class Cart
    {
        public Guid UserId { get; }
        public List<CartItem> Items { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
    }
}
