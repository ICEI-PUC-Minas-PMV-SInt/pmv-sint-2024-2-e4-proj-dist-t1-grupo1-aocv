using Timely.Models;

namespace Timely.Controllers
{
    public interface IViagemEventosRepository
    {
        void Add(ViagemEventos viagemEventos);
        ViagemEventos? Get(int id);
        void Update(ViagemEventos viagemEventos);
        void Dispose();
        void Save();
    }
}
