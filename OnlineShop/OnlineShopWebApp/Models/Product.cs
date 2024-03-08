namespace OnlineShopWebApp.Models
{
    public class Product
    {
        private static int uniqId;
        public int Id { get; }
        public string Name { get; private set; }
        public decimal Cost { get; private set; }
        public string Description { get; private set; }

        public Product(string name, decimal cost, string description)
        {
            Id = uniqId++;
            Name = name;
            Cost = cost;
            Description = description;
        }
        public override string ToString() 
        {
            return $"{Id} \n {Name} \n {Cost} \n {Description}";
        }
    }
}
