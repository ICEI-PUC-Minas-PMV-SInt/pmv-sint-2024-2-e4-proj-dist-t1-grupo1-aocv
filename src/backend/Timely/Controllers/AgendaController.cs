using Microsoft.AspNetCore.Mvc;
using Timely.Models;

namespace Timely.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgendaController : ControllerBase
    {
        private readonly InterfaceAgendaRepository _agenda;

        public AgendaController(InterfaceAgendaRepository agenda)
        {
            _agenda = agenda;
        }



        [HttpPost]
        public IActionResult Criar_Agenda(Agenda agenda)
        {
            _agenda.Add(agenda);
            _agenda.Save();
            return CreatedAtAction(nameof(Get), new { id = agenda.AgendaId }, agenda);

        }




        [HttpGet("{id}")]
         public ActionResult<Agenda> Get(int id)
        {
            var agenda = _agenda.Get(id);
            if (agenda == null)
                return NotFound();
            return Ok(agenda);
        }




        [HttpPut("{id}")]
        public IActionResult Update(int id, Agenda agenda)
        {
            if (id != agenda.AgendaId)
                return BadRequest();
            var existingAgenda = _agenda.Get(id);
            if (existingAgenda is null)
                return NotFound();

            _agenda.Update(agenda);
            _agenda.Save();

            return NoContent();
        }




    }
}