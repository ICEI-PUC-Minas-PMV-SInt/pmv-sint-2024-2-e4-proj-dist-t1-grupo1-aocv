using Timely.Controllers;
using Timely.Models;

namespace Timely.Respositories;

public class CadastroInMemory : ICadastroRepository
{
    private List<User>? Users { get; }
    private int nextId = 3;
    public CadastroInMemory()
    {
        Users =
        [
            new User {UserId = 1, Nome = "Carlos", Email = "carlos@gmail.com", Password = "12345678"},
            new User {UserId = 2, Nome = "Ana", Email = "ana@gmail.com", Password = "abcdefgh"}
        ];
    }

    public User? Get(int id) => Users.FirstOrDefault(t => t.UserId == id);

    public void Add(User user)
    {
        user.UserId = nextId++;
        Users.Add(user);
    }

    public void Update(User user)
    {
        var index = Users.FindIndex(t => t.UserId == user.UserId);
        if (index == -1)
            return;

        Users[index] = user;
    }

    public void Dispose() { }

    public void Save() { }
}
