namespace OnlineShopWebApp.Models
{
    public class Product
    {
        private static int uniqId;
        public int Id { get; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public string Description { get; private set; }

        public Product(string name, decimal price, string description)
        {
            Id = uniqId++;
            Name = name;
            Price = price;
            Description = description;
        }
        public override string ToString() 
        {
            return $"{Id} \n {Name} \n {Price} \n {Description}";
        }
    }
}
