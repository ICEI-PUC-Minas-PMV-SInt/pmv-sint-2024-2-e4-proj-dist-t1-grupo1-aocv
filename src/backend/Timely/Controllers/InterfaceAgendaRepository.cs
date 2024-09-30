using Timely.Models;

namespace Timely.Controllers
{
    public interface InterfaceAgendaRepository
    {
        void Add(Agenda agenda);
        Agenda? Get(int id);
        void Update(Agenda agenda);
        void Dispose();
        void Save();
    }
}