using System.ComponentModel.DataAnnotations;

namespace Timely.api.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        public string? NomeDoUsuario { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }

        //Usuario: Possui uma lista de Copromissos (Compromissos), representando o relacionamento um para muitos.
        public List<Compromisso>? Compromissos { get; set; }


    }
}