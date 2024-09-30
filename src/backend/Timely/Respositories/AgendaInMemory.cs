
using Timely.Controllers;
using Timely.Models;

namespace Timely.Respositories
{
    public class AgendaInMemory : InterfaceAgendaRepository
    {
        List<Agenda> Agendas { get; }
        private int nextId = 3;



        public AgendaInMemory()
        {
            Agendas =
            [
                new Agenda {AgendaId = 1, Name = "puc minas", Description = "viagem minas", Date = DateTime.Now},
                new Agenda {AgendaId = 2, Name = "Natal RN", Description = "viagem natal", Date = DateTime.Now}
            ];
        }


        public Agenda Get(int id) => Agendas.FirstOrDefault(t => t.AgendaId == id);

        public void Add(Agenda agenda)
        {
            agenda.AgendaId = nextId++;
            Agendas.Add(agenda);

        }



        public void Update(Agenda agenda)
        {
            var index = Agendas.FindIndex(t => t.AgendaId == agenda.AgendaId);
            if (index == -1)
                return;

            Agendas[index] = agenda;
        }


        public void Dispose() { }

        public void Save() { }


    }
}