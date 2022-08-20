using WebAPIPractice.Models;

namespace WebAPIPractice.Interfaces
{
    public interface IUserRepository
    {
        User? GetById(int id);
        void Create(User newUser);
        void Update(User updatedUser);
        void Delete(int id);
    }
}
