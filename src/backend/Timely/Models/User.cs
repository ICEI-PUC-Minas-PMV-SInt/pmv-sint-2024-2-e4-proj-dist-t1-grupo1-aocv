using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Timely.Models
{
    public class User
    {
     
        public int UserId { get; set; }
        
        public string Nome { get; set; }
        
        public string Email { get; set; }
        
        public string Password { get; set; }

        public IList<Agenda> Agendas { get; set; }

        public IList<Viagem> Viagens { get; set; }
    }
}
