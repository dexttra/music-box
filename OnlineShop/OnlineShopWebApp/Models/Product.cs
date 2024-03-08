namespace OnlineShopWebApp.Models
{
    public class Product
    {
        private static int UniqId;
        public int Id { get; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }

        public Product(string name, decimal cost, string description)
        {
            Id = UniqId++;
            Name = name;
            Cost = cost;
            Description = description;
        }
    }
}
