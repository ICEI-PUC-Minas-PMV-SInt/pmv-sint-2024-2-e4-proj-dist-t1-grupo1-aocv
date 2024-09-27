using System.ComponentModel.DataAnnotations.Schema;

namespace Timely.Models
{
    public class Viagem
    {
        public int ViagemId { get; set; }

        public string Name { get; set; }

        public DateTime Inicio { get; set; }

        public DateTime Final {  get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
