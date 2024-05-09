namespace OnlineShopWebApp.Models
{
    public class CartItem
    {
        private static int uniqId;
        public int Id { get; }
        public ProductViewModel Product { get; set; }
        public int Amount { get; set; }
        
        public CartItem(ProductViewModel product, int amount)
        {
            Id = uniqId++;
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
