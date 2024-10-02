namespace Timely.Repositories
{
    public interface ITarefaRepository : IDisposable
    {
        Tarefa Get(int id);
        IEnumerable<Tarefa> GetAll();
        void Add(Tarefa tarefa);
        void Update(Tarefa tarefa);
        void Delete(int id);
    }
}
