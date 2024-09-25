using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Timely.api.Models
{
    public class Compromisso
    {
        [Key]
        public int CompromissoId { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public bool EstaCompleto { get; set; }
        public DateTime CriadoEm { get; set; }


        //Usuario: Possui um UsuarioId como chave estrangeira e uma propriedade de navegação Usuario para acessar o Usuario associado
        [ForeignKey("UsuarioId")]
        public int UsuarioId { get; set; }

        //propriedade de navegação
        public Usuario? Usuario { get; set; }


    }
}