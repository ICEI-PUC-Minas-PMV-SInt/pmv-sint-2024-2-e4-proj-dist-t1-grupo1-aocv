using System.Xml.Linq;
using Timely.Controllers;
using Timely.Models;

namespace Timely.Respositories
{
    public class UserInMemory : IUserRepository
    {
        private List<User> UserList { get; }
        private int nextId = 3;

        public UserInMemory()
        {
            UserList = new List<User>
        {
            new User { UserId = 1, Nome = "João Silva", Email = "joao@gmail.com", Password = "senha123", Tarefas = new List<Tarefa>(), Viagens = new List<Viagem>() },
            new User { UserId = 2, Nome = "Maria Oliveira", Email = "maria@gmail.com", Password = "senha123", Tarefas = new List<Tarefa>(), Viagens = new List<Viagem>() }
        };
        }

        public User? Get(int id) => UserList.FirstOrDefault(u => u.UserId == id);

        public IEnumerable<User> GetAll() => UserList;

        public void Add(User user)
        {
            user.UserId = nextId++;
            UserList.Add(user);
        }

        public void Update(User user)
        {
            var index = UserList.FindIndex(u => u.UserId == user.UserId);
            if (index == -1)
                return;

            UserList[index] = user;
        }

        public void Delete(int id)
        {
            var user = Get(id);
            if (user != null)
            {
                UserList.Remove(user);
            }
        }
    }

}
