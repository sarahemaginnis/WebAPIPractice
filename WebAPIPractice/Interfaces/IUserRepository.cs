using WebAPIPractice.Models;

namespace WebAPIPractice.Interfaces
{
    public interface IUserRepository
    {
        User? GetById(int id);
    }
}
