namespace OnlineShopWebApp.Models
{
    public class Cart
    {
        public readonly int UserId;
        public List<Product> ProductsList {  get; set; } = new List<Product>();

        public Cart(int id) 
        {
            UserId = id;
        }

        public void AddProduct(Product product)
        {
            ProductsList.Add(product);
        }
    }
}
