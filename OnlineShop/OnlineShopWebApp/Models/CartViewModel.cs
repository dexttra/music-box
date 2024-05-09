namespace OnlineShopWebApp.Models
{
    public class CartViewModel
    {
        public Guid UserId { get; }
        public List<CartItemViewModel> Items { get; set; } = new List<CartItemViewModel>();

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

        public CartViewModel(Guid userId)
        {
            UserId = userId;
        }



    }
}
