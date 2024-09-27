using System.ComponentModel.DataAnnotations.Schema;

namespace Timely.Models
{
    public class ViagemEventos
    {
        public int ViagemEventosId { get; set; }

        public string Descricao  { get; set; }

        public DateTime Horario { get; set; }

        public string Nome { get; set; }

        public int ViagemId { get; set; }
        [ForeignKey("ViagemId")]
        public Viagem Viagem { get; set; }
    }
}
