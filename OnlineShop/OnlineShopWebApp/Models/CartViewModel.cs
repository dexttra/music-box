namespace OnlineShopWebApp.Models
{
    public class CartViewModel
    {
        public Guid UserId { get; set; }
        public List<CartItemViewModel> Items { get; set; }

        public decimal Price
        {
            get
            {
                return Items.Sum(x => x.Price);
            }
            set { }
        }

        public int Amount
        {
            get
            {
                return Items?.Sum(x => x.Amount) ?? 0;
            }
            set { }
        }

    }
}
