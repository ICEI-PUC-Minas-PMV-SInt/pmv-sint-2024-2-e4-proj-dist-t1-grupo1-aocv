using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Timely.api.Context;
using Timely.api.Models;

namespace Timely.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly BancoDedadosContext _context;

       //construtor
       public UsuarioController(BancoDedadosContext context)
       {
          _context = context;
       }

        //criarUsuario
        [HttpPost]
        public IActionResult Criar(Usuario usuario)
        {
            _context.Add(usuario);
            _context.SaveChanges();
            return Ok(usuario);
        }


        //obter por id
        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var usuario = _context.Usuarios.Find(id);

            if(usuario == null)
                return NotFound();

            return Ok(usuario);

        }
    }
}