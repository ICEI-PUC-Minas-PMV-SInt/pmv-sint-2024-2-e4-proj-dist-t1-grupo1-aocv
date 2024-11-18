using Timely.Models;

namespace Timely.Controllers
{
    public interface IUserRepository
    {
        void Add(User user);
        User? Get(int id);
        void Update(User user);
        void Delete(int id);
        IEnumerable<User> GetAll();
    }

}
