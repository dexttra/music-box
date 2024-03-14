namespace OnlineShopWebApp.Models
{
    public class User
    {
        private static int uniqId;
        public int Id { get; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Email { get; private set; }

        public User(string name, string surname, string email)
        {
            Id = uniqId++;
            Name = name;
            Surname = surname;
            Email = email;
        }
    }
}
