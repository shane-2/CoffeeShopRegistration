namespace CoffeeShopRegistration.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string FavoriteFlavor { get; set;}
        public bool Caffeine { get; set;}
        public string Requirements { get; set; }
    }
}
