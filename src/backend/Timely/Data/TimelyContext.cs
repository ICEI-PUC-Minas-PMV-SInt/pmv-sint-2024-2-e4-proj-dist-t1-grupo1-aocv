using Microsoft.EntityFrameworkCore;
using Timely.Models;

namespace Timely.Data
{
    public class TimelyContext : DbContext
    {
        // Construtor que passa as opções para a classe base DbContext
        public TimelyContext(DbContextOptions<TimelyContext> options) : base(options)
        {
        }

        // DbSet que mapeia a entidade Todo para o banco de dados
        public DbSet<User> User { get; set; }
        public DbSet<Agenda> Agenda { get; set; }
        public DbSet<Viagem> Viagem { get; set;}
        public DbSet<ViagemEventos> ViagemEventos { get; set; }
    }
}
