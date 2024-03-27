namespace OnlineShopWebApp.Models
{
    public class Cart
    {
        public int UserId { get; }
        public List<CartItem> Items { get; set; } = new List<CartItem>();

        public decimal Price
        {
            get
            {
                return Items.Sum(x => x.Price);
            }
        }

        public int Amount
        {
            get
            {
                return Items?.Sum(x => x.Amount) ?? 0;
            }
        }

        public Cart(int userId)
        {
            UserId = userId;
        }



    }
}
