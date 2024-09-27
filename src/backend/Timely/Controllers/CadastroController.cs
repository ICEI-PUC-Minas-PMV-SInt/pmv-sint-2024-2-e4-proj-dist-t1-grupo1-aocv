using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Timely.Models;

namespace Timely.Controllers
{
    [Route("/cadastro")]
    [ApiController]
    public class CadastroController : ControllerBase
    {
        private readonly ICadastroRepository _cadastro;

        public CadastroController(ICadastroRepository cadastro)
        {
            _cadastro = cadastro;
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            _cadastro.Add(user);
            _cadastro.Save();

            return CreatedAtAction(nameof(Get), new { id = user.UserId }, user);
        }

        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            var user = _cadastro.Get(id);

            if (user == null)
                return NotFound();

            return Ok(user);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, User user)
        {
            if (id != user.UserId)
                return BadRequest();

            var existingUser = _cadastro.Get(id);
            if (existingUser is null)
                return NotFound();

            _cadastro.Update(user);
            _cadastro.Save();

            return NoContent();
        }
    }
}
