using Timely.Models;

namespace Timely.Controllers
{
    public interface ICadastroRepository
    {
        void Add(User user);
        User? Get(int id);
        void Update(User user);
        void Dispose();
        void Save();
    }
}



