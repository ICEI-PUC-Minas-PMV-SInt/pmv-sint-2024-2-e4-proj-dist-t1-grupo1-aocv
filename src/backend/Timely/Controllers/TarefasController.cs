using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace agenda_pessoal.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/usuarios/{usuarioId}/tarefas")]
    public class TarefasController : ControllerBase
    {
        private static List<Tarefa> tarefas = new List<Tarefa>();

        [HttpGet]
        public IActionResult ObterTarefas(int usuarioId)
        {
            var usuarioTarefas = tarefas.Where(t => t.UsuarioId == usuarioId).ToList();
            return Ok(usuarioTarefas);
        }

        [HttpGet("{tarefaId}")]
        public IActionResult ObterTarefa(int usuarioId, int tarefaId)
        {
            var tarefa = tarefas.FirstOrDefault(t => t.UsuarioId == usuarioId && t.TarefaId == tarefaId);
            if (tarefa == null)
            {
                return NotFound();
            }
            return Ok(tarefa);
        }

        [HttpPost]
        public IActionResult CriarTarefa(int usuarioId, [FromBody] Tarefa novaTarefa)
        {
            novaTarefa.UsuarioId = usuarioId;
            novaTarefa.TarefaId = tarefas.Count + 1;
            tarefas.Add(novaTarefa);
            return CreatedAtAction(nameof(ObterTarefa), new { usuarioId = usuarioId, tarefaId = novaTarefa.TarefaId }, novaTarefa);
        }
       
        [HttpPut("{tarefaId}")]
        public IActionResult AtualizarTarefa(int usuarioId, int tarefaId, [FromBody] Tarefa tarefaAtualizada)
        {
            var tarefa = tarefas.FirstOrDefault(t => t.UsuarioId == usuarioId && t.TarefaId == tarefaId);
            if (tarefa == null)
            {
                return NotFound();
            }

            tarefa.Titulo = tarefaAtualizada.Titulo;
            tarefa.Descricao = tarefaAtualizada.Descricao;
            tarefa.DataVencimento = tarefaAtualizada.DataVencimento;
            tarefa.Concluida = tarefaAtualizada.Concluida;

            return NoContent();
        }

        [HttpDelete("{tarefaId}")]
        public IActionResult ExcluirTarefa(int usuarioId, int tarefaId)
        {
            var tarefa = tarefas.FirstOrDefault(t => t.UsuarioId == usuarioId && t.TarefaId == tarefaId);
            if (tarefa == null)
            {
                return NotFound();
            }

            tarefas.Remove(tarefa);
            return NoContent();
        }
    }
}