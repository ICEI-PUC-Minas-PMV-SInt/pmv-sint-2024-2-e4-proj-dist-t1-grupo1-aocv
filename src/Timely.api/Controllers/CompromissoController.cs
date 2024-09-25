using Microsoft.AspNetCore.Mvc;
using Timely.api.Context;
using Timely.api.Models;

namespace Timely.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompromissoController : ControllerBase
    {
        private readonly BancoDedadosContext _context;


        //construtor
        public CompromissoController(BancoDedadosContext context)
        {
            _context = context;
        }


        //criarCompromisso
        [HttpPost]
        public IActionResult Criar(Compromisso compromisso)
        {
            _context.Add(compromisso);
            _context.SaveChanges();
            return Ok(compromisso);
        }


        //obter por id
        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var compromisso = _context.Compromissos.Find(id);

            if (compromisso == null)
                return NotFound();

            return Ok(compromisso);

        }


    }
}