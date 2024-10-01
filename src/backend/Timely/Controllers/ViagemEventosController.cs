using Microsoft.AspNetCore.Mvc;
using Timely.Models;

namespace Timely.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ViagemEventosController : ControllerBase
    {
        private readonly IViagemEventosRepository _viagemEventosRepository;

        public ViagemEventosController(IViagemEventosRepository viagemEventosRepository)
        {
            _viagemEventosRepository = viagemEventosRepository;
        }

        [HttpPost]
        public IActionResult Criar_ViagemEvento(ViagemEventos viagemEvento)
        {
            _viagemEventosRepository.Add(viagemEvento);
            _viagemEventosRepository.Save();
            return CreatedAtAction(nameof(Get), new { id = viagemEvento.ViagemEventosId }, viagemEvento);
        }

        [HttpGet("{id}")]
        public ActionResult<ViagemEventos> Get(int id)
        {
            var viagemEvento = _viagemEventosRepository.Get(id);
            if (viagemEvento == null)
                return NotFound();
            return Ok(viagemEvento);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, ViagemEventos viagemEvento)
        {
            if (id != viagemEvento.ViagemEventosId)
                return BadRequest();

            var existingViagemEvento = _viagemEventosRepository.Get(id);
            if (existingViagemEvento is null)
                return NotFound();

            _viagemEventosRepository.Update(viagemEvento);
            _viagemEventosRepository.Save();

            return NoContent();
        }
    }
}
