using System;
using System.Collections.Generic;
using System.Linq;

namespace Timely.Repositories
{
    public class TarefaInMemory : ITarefaRepository
    {
        private List<Tarefa> Tarefas { get; set; }
        private int nextId = 3;

        public TarefaInMemory()
        {
            Tarefas = new List<Tarefa>
            {
                new Tarefa {TarefaId = 1, UsuarioId = 1, Titulo = "Estudar para prova", Descricao = "Estudar para a prova de matemática", DataVencimento = DateTime.Now.AddDays(2), Concluida = false},
                new Tarefa {TarefaId = 2, UsuarioId = 2, Titulo = "Comprar presente", Descricao = "Comprar presente de aniversário", DataVencimento = DateTime.Now.AddDays(5), Concluida = false}
            };
        }

        public Tarefa Get(int id) => Tarefas.FirstOrDefault(t => t.TarefaId == id);

        public IEnumerable<Tarefa> GetAll()
        {
            return Tarefas;
        }

        public void Add(Tarefa tarefa)
        {
            tarefa.TarefaId = nextId++;
            Tarefas.Add(tarefa);
        }

        public void Update(Tarefa tarefa)
        {
            var index = Tarefas.FindIndex(t => t.TarefaId == tarefa.TarefaId);
            if (index == -1)
                return;

            Tarefas[index] = tarefa;
        }

        public void Delete(int id)
        {
            var tarefa = Tarefas.FirstOrDefault(t => t.TarefaId == id);
            if (tarefa != null)
                Tarefas.Remove(tarefa);
        }

        public void Dispose() { }

        public void Save() { }
    }
}
