using System;
using System.Collections.Generic;
using System.Linq;
using Timely.Models;
using Timely.Controllers;

namespace Timely.Repositories
{
    public class ViagemEventosInMemory : IViagemEventosRepository
    {
        List<ViagemEventos> ViagemEventosList { get; }
        private int nextId = 3;

        public ViagemEventosInMemory()
        {
            ViagemEventosList = new List<ViagemEventos>
            {
                new ViagemEventos { ViagemEventosId = 1, Nome = "Chegada", Descricao = "Chegada em Minas Gerais", Horario = DateTime.Now, ViagemId = 1 },
                new ViagemEventos { ViagemEventosId = 2, Nome = "Saída", Descricao = "Partida para Natal", Horario = DateTime.Now.AddHours(3), ViagemId = 2 }
            };
        }

        public ViagemEventos Get(int id) => ViagemEventosList.FirstOrDefault(t => t.ViagemEventosId == id);

        public void Add(ViagemEventos viagemEvento)
        {
            viagemEvento.ViagemEventosId = nextId++;
            ViagemEventosList.Add(viagemEvento);
        }

        public void Update(ViagemEventos viagemEvento)
        {
            var index = ViagemEventosList.FindIndex(t => t.ViagemEventosId == viagemEvento.ViagemEventosId);
            if (index == -1)
                return;

            ViagemEventosList[index] = viagemEvento;
        }

        public void Dispose() { }

        public void Save() { }
    }
}
