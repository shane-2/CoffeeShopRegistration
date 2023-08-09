namespace CoffeeShopRegistration.Models
{
    public class UserList
    {
        public List<User> Users = new List<User>();

    //public UserList()
    //{
    //    Users.Add(new User());
    //}


        public void AddNew(User c)
        {
            Users.Add(c);
        }
    }
}

