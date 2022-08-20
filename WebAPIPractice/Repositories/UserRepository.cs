using WebAPIPractice.Interfaces;
using WebAPIPractice.Models;

namespace WebAPIPractice.Repositories
{
    public class UserRepository : IUserRepository
    {
        private static List<User> _userData = new()
        {
            new User()
            {
                Id = 1,
                FirstName = "Brian",
                LastName = "Neal",
                StreetAddress = "123 Main Street",
                City = "Nashville",
                State = "TN",
                ZipCode = "37208",
                ProfilePicURL = "dummyProfilePicURL"
            },
            new User()
            {
                Id = 2,
                FirstName = "Sarah",
                LastName = "Maginnis",
                StreetAddress = "456 Other Street",
                City = "Nashville",
                State = "TN",
                ZipCode = "37208",
                ProfilePicURL = "dummyProfilePicURL2"

            }
        };
        public User? GetById(int id)
        {
            return _userData.FirstOrDefault(u => u.Id == id);
        }

    }
}
