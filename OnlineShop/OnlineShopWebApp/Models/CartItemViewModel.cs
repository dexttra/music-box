namespace OnlineShopWebApp.Models
{
    public class CartItemViewModel
    {
        private static int uniqId;
        public Guid Id { get; }
        public ProductViewModel Product { get; set; }
        public int Amount { get; set; }
        
        public CartItemViewModel(ProductViewModel product, int amount)
        {
            Id = new Guid();
            Product = product;
            Amount = amount;
        }

        public decimal Price
        {
            get
            {
                return Product.Price * Amount;
            }
        }

    
    }
}
