using Microsoft.EntityFrameworkCore;
using Timely.api.Models;

namespace Timely.api.Context
{
    public class BancoDedadosContext : DbContext
    {
        public BancoDedadosContext(DbContextOptions<BancoDedadosContext> options) : base(options)
        {

        }
        
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Compromisso> Compromissos { get; set; }


        
    }
}