using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Timely.Models
{
    public class Viagens
    {
        //public int IdUsuario_FK{ get; set; }
        public int Id { get; set; }
        public int IdViagem { get; set; }
        public string? Nome { get; set; }

        [Display(Name = "Descrição" )]
        public string? Descricao { get; set; }
        public DateTime DataInicio { get; set; } = DateTime.UtcNow;
        public DateTime DataTermino { get; set; } = DateTime.UtcNow;
    }
}