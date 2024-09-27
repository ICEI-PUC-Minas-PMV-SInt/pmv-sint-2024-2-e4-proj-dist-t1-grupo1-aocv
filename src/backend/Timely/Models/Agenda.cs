using System.ComponentModel.DataAnnotations.Schema;

namespace Timely.Models
{
    public class Agenda
    {
        public int AgendaId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; } 

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
